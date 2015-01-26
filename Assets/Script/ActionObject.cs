using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 入力された文字列からオブジェクトのアクションを実行する
/// 継承したクラスでは実行するアクションをオーバーライドする
/// </summary>
public class ActionObject : MonoBehaviour
{
    [SerializeField]
    private List<string> keywords = default(List<string>);

    private ActionWord action;
    private string line;

    public bool actionFlag { get; private set; }

    public void SetActionFlag()
    {
        actionFlag = true;
    }

    protected virtual void FoundAction()
    {
        InputBuffer.allowInput = false;
    }

    protected virtual void MissingAction()
    {
        InputBuffer.allowInput = true;
    }

    private void Start()
    {
        //キーワード全てを大文字に変換
        for(int i = 0; i < keywords.Count; ++i)
            keywords[i] = keywords[i].ToUpper();
        //アクションの追加
        action = new ActionWord(keywords, FoundAction, MissingAction);
    }

    private void Update()
    {
        //フラグが立っていたら
        if(actionFlag)
        {
            line = InputBuffer.GetLineBuffer();
            action.DoAction(line);
            actionFlag = false;
        }
    }
}