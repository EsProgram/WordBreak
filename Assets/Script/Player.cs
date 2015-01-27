using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject magicEffect = default(GameObject);

    private void Update()
    {
        if(Input.GetKey(KeyCode.Return) && InputBuffer.allowInput)
            if(InputBuffer.GetLineBuffer().Length > 0)
            {
                InputBuffer.allowInput = false;
                GameObject.Instantiate(magicEffect, transform.position, Quaternion.identity);
                StartCoroutine(CallSetActionFlag());
            }
    }

    private IEnumerator CallSetActionFlag()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject.FindGameObjectWithTag("Enemy").SendMessage("SetActionFlag");
    }
}