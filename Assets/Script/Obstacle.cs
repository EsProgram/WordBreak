using System.Collections;
using UnityEngine;

/// <summary>
/// 障害物のアクション
/// </summary>
public class Obstacle : ActionObject
{
    [SerializeField]
    private GameObject effectOnDestroy = default(GameObject);

    private int hp;

    protected override void FoundAction()
    {
        base.FoundAction();
    }

    protected override void MissingAction()
    {
        base.MissingAction();
    }
}