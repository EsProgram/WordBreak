using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject magicEffect = default(GameObject);

    private void Update()
    {
        if(Input.GetKey(KeyCode.Return))
            if(InputBuffer.GetLineBuffer().Length > 0)
            {
                GameObject.Instantiate(magicEffect, transform.position, Quaternion.identity);
            }
    }
}