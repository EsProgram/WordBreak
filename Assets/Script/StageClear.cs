using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StageClear : MonoBehaviour
{
    public static bool isclear = false;
    private Text text;

    public void Awake()
    {
        text = GetComponent<Text>();
    }

    private void Start()
    {
        text.enabled = false;
        isclear = false;
    }

    private void Update()
    {
        if(isclear && !text.enabled)
            text.enabled = true;

        //クリアしてスペースキーが押されたらタイトルにもどる
        if(isclear && Input.GetKey(KeyCode.Space))
        {
            isclear = false;
            text.enabled = false;
            Application.LoadLevel(0);
        }
    }
}