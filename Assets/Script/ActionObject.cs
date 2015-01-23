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
    private GameObject effectOnDestroy = default(GameObject);

    private ActionWord action;
    private string line;

    public void Awake()
    {
    }

    public void Start()
    {
        //アクションの追加
        action = new ActionWord(keywords,
            () =>
            {
                Debug.Log("見つかりました");
                GameObject.Instantiate(effectOnDestroy, transform.position, Quaternion.identity);
                Destroy(gameObject, 1f);
            },
            () =>
            {
                Debug.Log("見つかりませんでした");
            }
            );

        //キーワード全てを大文字に変換
        for(int i = 0; i < keywords.Count; ++i)
            keywords[i] = keywords[i].ToUpper();
    }

    private void Update()
    {
        //returnキーが押されたらバッファの1行をとってきてアクションする
        if(Input.GetKeyDown(KeyCode.Return))
        {
            line = InputBuffer.GetLineBuffer();
            action.DoAction(line);
        }
    }
}