using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class InputBuffer : MonoBehaviour
{
    private const int MAX_LENGTH = 10;
    private static string line_buf;
    private Text inputView;
    private ConvertInputKey2Char key_converter;
    private StringBuilder input;

    private InputBuffer()
    {
    }

    public void Awake()
    {
        inputView = GameObject.FindWithTag("ShowText").GetComponent<Text>();
        key_converter = ConvertInputKey2Char.GetInstance();
    }

    public void Start()
    {
        line_buf = string.Empty;
        input = new StringBuilder();
    }

    private void Update()
    {
        switch(key_converter.GetCurrentKeyDown())
        {
            case '\0':
                break;

            case ' ':
                break;

            case '\n':
                line_buf = input.ToString();
                input = new StringBuilder();
                inputView.text = "";
                break;

            case '\b':
                if(input.Length > 0)
                    input.Remove(input.Length - 1, 1);
                break;

            default:
                if(input.Length < MAX_LENGTH)
                    input.Append(key_converter.GetCurrentKeyDown());
                break;
        }

        //Viewに表示する
        inputView.text = input.ToString();
    }

    /// <summary>
    /// バッファに最後に保存された1行を返す
    /// </summary>
    /// <returns></returns>
    public static string GetLineBuffer()
    {
        return line_buf;
    }
}