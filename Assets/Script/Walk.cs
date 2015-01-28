using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 敵/障害物　等の移動制御
/// </summary>
public class Walk : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = -1f;

    [SerializeField]
    private float limit_time = 10f;

    private Text limit_text;
    private float spawn_time;
    private bool show = false;
    private float timer;

    public void Awake()
    {
        limit_text = GameObject.FindGameObjectWithTag("Time").GetComponent<Text>();
    }

    public bool walking { get; private set; }

    public void Start()
    {
        walking = true;
    }

    public void Stop()
    {
        spawn_time = Time.time;
        walking = false;
        show = true;
    }

    private void Update()
    {
        if(show)
        {
            timer = limit_time - Time.time + spawn_time;
            limit_text.text = timer.ToString();
            if(timer < 0)
            {
                //ゲームオーバー
                EnemyControl.born = true;
                Application.LoadLevel("GameOver");
            }
        }
        if(walking)
            transform.Translate(walkSpeed * Time.deltaTime, 0, 0);
    }

    public void OnDestroy()
    {
    }
}