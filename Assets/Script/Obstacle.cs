using System.Collections;
using UnityEngine;

/// <summary>
/// 障害物のアクション
/// </summary>
public class Obstacle : ActionObject
{
    [SerializeField]
    private GameObject effectOnDestroy = default(GameObject);

    [SerializeField]
    private GameObject effectOnFoundKey = default(GameObject);

    [SerializeField]
    private GameObject effectOnMissingKey = default(GameObject);

    private Walk walk = default(Walk);

    private int hp;

    public void Awake()
    {
        walk = GetComponent<Walk>();
    }

    protected override void FoundAction()
    {
        if(!walk.walking)
        {
            GameObject.Instantiate(effectOnDestroy, transform.position, Quaternion.identity);
            Destroy(gameObject, 1f);
        }
    }

    protected override void MissingAction()
    {
    }
}