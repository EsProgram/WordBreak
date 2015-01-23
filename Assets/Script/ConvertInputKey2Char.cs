using System.Collections;
using UnityEngine;

/// <summary>
/// 入力されたキーをchar型の文字に変換し保持する
/// </summary>
public class ConvertInputKey2Char : MonoBehaviour
{
    private char buf = default(char);

    public static ConvertInputKey2Char GetInstance()
    {
        return FindObjectOfType<ConvertInputKey2Char>();
    }

    private ConvertInputKey2Char()
    {
    }

    private void Update()
    {
        buf = '\0';

        if(Input.GetKeyDown(KeyCode.A))
            buf = KeyCode.A.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.B))
            buf = KeyCode.B.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.C))
            buf = KeyCode.C.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.D))
            buf = KeyCode.D.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.E))
            buf = KeyCode.E.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.F))
            buf = KeyCode.F.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.G))
            buf = KeyCode.G.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.H))
            buf = KeyCode.H.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.I))
            buf = KeyCode.I.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.J))
            buf = KeyCode.J.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.K))
            buf = KeyCode.K.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.L))
            buf = KeyCode.L.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.M))
            buf = KeyCode.M.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.N))
            buf = KeyCode.N.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.O))
            buf = KeyCode.O.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.P))
            buf = KeyCode.P.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Q))
            buf = KeyCode.Q.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.R))
            buf = KeyCode.R.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.S))
            buf = KeyCode.S.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.T))
            buf = KeyCode.T.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.U))
            buf = KeyCode.U.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.V))
            buf = KeyCode.V.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.W))
            buf = KeyCode.W.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.X))
            buf = KeyCode.X.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Y))
            buf = KeyCode.Y.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Z))
            buf = KeyCode.Z.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Return))
            buf = KeyCode.Return.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Space))
            buf = KeyCode.Space.KeyCode2Char();
        if(Input.GetKeyDown(KeyCode.Backspace))
            buf = KeyCode.Backspace.KeyCode2Char();
    }

    /// <summary>
    /// キーボードからの入力をcharで取得する
    /// そのフレーム内で押されていなかった場合は'\0'になる
    /// </summary>
    /// <returns>押されたキーのchar値</returns>
    public char GetCurrentKeyDown()
    {
        return buf;
    }
}