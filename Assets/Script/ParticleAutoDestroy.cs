using System.Collections;
using UnityEngine;

/// <summary>
/// パーティクルの自動破棄
/// </summary>
public class ParticleAutoDestroy : MonoBehaviour
{
    private void Start()
    {
        particleSystem.loop = false;
        Destroy(gameObject, particleSystem.duration + particleSystem.startLifetime + particleSystem.startDelay + 1f);
    }
}