using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class StopEnemy : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag.Equals("Enemy"))
        {
            coll.gameObject.SendMessage("Stop");
            Scroll.Stop();
        }
    }
}