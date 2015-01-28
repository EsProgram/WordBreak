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
        yield return new WaitForSeconds(2f);
        EnemyControl.gameState = EnemyControl.GameState.Play;
        Scroll.Run();
        Destroy(this);
    }
}