using System.Collections;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
    public float time = 1f;

    private void Start()
    {
        Destroy(gameObject, time);
    }
}