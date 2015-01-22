using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 入力された文字列からオブジェクトのアクションを実行する
/// </summary>
public class ActionObject : MonoBehaviour
{
    [SerializeField]
    private List<string> keywords = default(List<string>);

    [SerializeField]
    private GameObject effectOnDestroy;

    private const int MAX_LENGTH = 20;

    private Text inputView;
    private ActionWord action;
    private ConvertInputKey2Char key_converter;
    private StringBuilder input;

    public void Start()
    {
        action = new ActionWord(keywords,
            () =>
            {
                Debug.Log(string.Format("{0}が見つかりました", input.ToString()));
                GameObject.Instantiate(effectOnDestroy, transform.position, Quaternion.identity);
                Destroy(gameObject, 1f);
            },
            () =>
            {
                Debug.Log(string.Format("{0}が見つかりませんでした", input.ToString()));
            }
            );
        key_converter = ConvertInputKey2Char.GetInstance();
        input = new StringBuilder();
        inputView = FindObjectOfType<Text>();

        //キーワード全てを大文字に変換
        for(int i = 0; i < keywords.Count; ++i)
            keywords[i] = keywords[i].ToUpper();
    }

    private void Update()
    {
        //Spaceは無視
        if(key_converter.GetCurrentKeyDown() == ' ')
            return;
        //リターンキーならそれまでの文字をイベントに送る
        if(key_converter.GetCurrentKeyDown() == '\n')
        {
            action.DoAction(input.ToString());
            input = new StringBuilder();
            inputView.text = "";
            return;
        }
        //押されたキーをアペンドする(制限数以上は入力不可)
        if(key_converter.GetCurrentKeyDown() != '\0')
            //Backspaceなら1文字消す
            if(key_converter.GetCurrentKeyDown() == '\b')
            {
                if(input.Length > 0)
                    input.Remove(input.Length - 1, 1);
            }
            else if(input.Length < MAX_LENGTH)
                input.Append(key_converter.GetCurrentKeyDown());
        //Viewに表示する
        inputView.text = input.ToString();
    }
}