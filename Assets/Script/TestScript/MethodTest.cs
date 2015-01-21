using System.Collections;
using UnityEngine;

public class MethodTest : MonoBehaviour
{
    private ConvertInputKey2Char c;

    public void Awake()
    {
        c = FindObjectOfType<ConvertInputKey2Char>();
    }

    private void Update()
    {
        Debug.Log(c.GetCurrentKeyDown() == '\n' ? "Return!" : c.GetCurrentKeyDown().ToString());
    }
}