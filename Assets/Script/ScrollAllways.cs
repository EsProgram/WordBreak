using System.Collections;
using UnityEngine;

public class ScrollAllways : MonoBehaviour
{
    private SpriteRenderer sr;

    [SerializeField]
    private float speed = 1f;

    public void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        transform.position += Vector3.right * sr.bounds.size.x * 2;
    }
}