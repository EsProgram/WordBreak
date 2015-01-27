using System.Collections;
using UnityEngine;

public class StageStart : MonoBehaviour
{
    private bool start;

    public void Start()
    {
        start = true;
    }

    private void Update()
    {
        if(start)
        {
            Scroll.Stop();
            StartCoroutine(StartGame());
            start = false;
        }
    }

    private IEnumerator StartGame()
    {
        //ゲームスタート前にやりたい処理
        Debug.Log("ゲームスタート時の処理ができます");

        yield return new WaitForSeconds(2f);
        EnemyControl.gameState = EnemyControl.GameState.Play;
        Scroll.Run();
        Destroy(this);
    }
}