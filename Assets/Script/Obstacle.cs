using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 障害物のアクション
/// </summary>
public class Obstacle : ActionObject
{
    [SerializeField]
    private int hp = 1;

    [SerializeField]
    private GameObject effectOnDestroy = default(GameObject);

    [SerializeField]
    private GameObject effectOnFoundKey = default(GameObject);

    [SerializeField]
    private GameObject effectOnMissingKey = default(GameObject);

    public void Awake()
    {
        walk = GetComponent<Walk>();
    }

    protected override void FoundAction()
    {
        if(!walk.walking)
        {
            base.FoundAction();
            hp--;
            if(hp > 0)
            {
                //ダメージを受けた際の動作
                GameObject.Instantiate(effectOnFoundKey, transform.position, Quaternion.identity);
            }
            if(hp <= 0)
            {
                //破壊時の動作
                GameObject.Instantiate(effectOnDestroy, transform.position, Quaternion.identity);
                Scroll.Run();
                EnemyControl.born = true;
                Destroy(gameObject, 1f);
            }
        }
    }

    protected override void MissingAction()
    {
        base.MissingAction();
        GameObject.Instantiate(effectOnMissingKey, transform.position, Quaternion.identity);
    }
}