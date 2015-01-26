using System.Collections;
using UnityEngine;

/// <summary>
/// 敵/障害物　等の移動制御
/// </summary>
public class Walk : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = -1f;

    public bool walking { get; private set; }

    public void Start()
    {
        walking = true;
    }

    public void Stop()
    {
        walking = false;
    }

    private void Update()
    {
        if(walking)
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
    }
}