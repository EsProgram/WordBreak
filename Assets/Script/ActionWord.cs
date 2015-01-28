using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// クラス作成時に登録されたワードリストに含まれるキーワードが与えられた場合に、クラス作成時に登録されたアクションを実行するクラス
/// </summary>
public class ActionWord
{
    private readonly IList<string> keywords;
    private readonly Action foundAction;
    private readonly Action missingAction;

    /// <summary>
    /// キーワードによってアクションが実行されるクラスを生成する
    /// </summary>
    /// <param name="keywords">キーを含むワードリスト</param>
    /// <param name="foundAction">キー発見時のアクション</param>
    /// <param name="missingAction">キーが発見できなかった時のアクション</param>
    public ActionWord(IList<string> keywords, Action foundAction, Action missingAction = null)
    {
        this.keywords = keywords;
        this.foundAction = foundAction;
        this.missingAction = missingAction;

        //アクションがNULLの場合何もしないようにする
        foundAction = foundAction == null ? () => { } : foundAction;
        missingAction = missingAction == null ? () => { } : missingAction;
    }

    /// <summary>
    /// キーワードを渡し、リストに該当した場合/該当しなかった場合のそれぞれのアクションを実行する
    /// </summary>
    /// <param name="key">キーワード</param>
    public void DoAction(string key)
    {
        if(keywords.Contains(key))
        {
            keywords.Remove(key);
            foundAction();
        }
        else
            missingAction();
    }
}