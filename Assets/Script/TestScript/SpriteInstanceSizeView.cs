using System.Collections;
using UnityEngine;

public class SpriteInstanceSizeView : MonoBehaviour
{
    public GameObject spriteObject;
    private SpriteRenderer sr;

    public void Awake()
    {
        sr = spriteObject.GetComponent<SpriteRenderer>();
    }

    public void Start()
    {
        Debug.Log("If you press Space key, get size of sprite.");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PixelSize: " + sr.bounds.size * sr.sprite.pixelsPerUnit);
            Debug.Log("UnitSize: " + sr.bounds.size);
        }
    }
}