using System.Collections;
using UnityEngine;

public class MethodTest : MonoBehaviour
{
    public GameObject pref;

    public void Awake()
    {
        Instantiate(pref);
    }

    private void Update()
    {
    }
}