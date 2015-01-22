using System.Collections;
using UnityEngine;

/// <summary>
/// パーティクルの自動破棄
/// </summary>
public class ParticleAutoDestroy : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, particleSystem.duration + particleSystem.startLifetime + particleSystem.startDelay + 1f);
    }
}