using System.Collections;
using UnityEngine;

public class StageLoader : MonoBehaviour
{
    [SerializeField]
    private int loadStage = 1;

    public void LoadStage()
    {
        Application.LoadLevel(loadStage);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            LoadStage();
    }
}