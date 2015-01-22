using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class KeyCodeExtension
{
    /// <summary>
    /// キーコードを文字に変換して返す
    /// A-Z,Return,Spaceに対応
    /// </summary>
    /// <param name="keycode">変換対象</param>
    /// <returns></returns>
    public static char KeyCode2Char(this KeyCode keycode)
    {
        char ret = '\0';
        switch(keycode)
        {
            case KeyCode.A:
                break;

            case KeyCode.B:
                break;

            case KeyCode.C:
                break;

            case KeyCode.D:
                break;

            case KeyCode.E:
                break;

            case KeyCode.F:
                break;

            case KeyCode.G:
                break;

            case KeyCode.H:
                break;

            case KeyCode.I:
                break;

            case KeyCode.J:
                break;

            case KeyCode.K:
                break;

            case KeyCode.L:
                break;

            case KeyCode.M:
                break;

            case KeyCode.N:
                break;

            case KeyCode.O:
                break;

            case KeyCode.P:
                break;

            case KeyCode.Q:
                break;

            case KeyCode.R:
                break;

            case KeyCode.S:
                break;

            case KeyCode.T:
                break;

            case KeyCode.U:
                break;

            case KeyCode.V:
                break;

            case KeyCode.W:
                break;

            case KeyCode.X:
                break;

            case KeyCode.Y:
                break;

            case KeyCode.Z:
                break;

            case KeyCode.Return:
                ret = '\n';
                break;

            case KeyCode.Space:
                ret = ' ';
                break;

            default:
                //例外
                throw new CodeNotFoundException("指定されたキーコードに対応する文字が見つかりませんでした");
        }
        return ret == '\0' ? keycode.ToString().First() : ret;
    }
}