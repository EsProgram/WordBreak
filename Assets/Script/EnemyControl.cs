using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemys = default(List<GameObject>);

    private GameObject currentEnemy;

    private void Update()
    {
        if(currentEnemy == null)
        {
            int index = Random.Range(0, enemys.Count);
            currentEnemy = GameObject.Instantiate(enemys[index]) as GameObject;
        }
    }
}