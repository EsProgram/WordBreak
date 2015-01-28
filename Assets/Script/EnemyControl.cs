using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public enum GameState
    {
        Start,
        Play,
        End,
    }

    public static GameState gameState = GameState.Start;
    public static bool born = true;

    [SerializeField]
    private List<GameObject> enemys = default(List<GameObject>);

    private int index = 0;
    private GameObject currentEnemy;

    private void Update()
    {
        switch(gameState)
        {
            case GameState.Start:
                break;

            case GameState.Play:
                if(currentEnemy == null)
                    if(index < enemys.Count)
                    {
                        if(born)
                        {
                            //召喚
                            StartCoroutine(Born());
                            born = false;
                        }
                    }
                    else
                    {
                        //ステージクリア
                        StageClear.isclear = true;
                    }
                break;

            case GameState.End:
                break;

            default:
                break;
        }
    }

    private IEnumerator Born()
    {
        yield return new WaitForSeconds(3f);
        currentEnemy = GameObject.Instantiate(enemys[index++]) as GameObject;
    }
}