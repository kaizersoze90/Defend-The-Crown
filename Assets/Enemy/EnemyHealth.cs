using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    int currentHitPoint;

    void OnEnable()
    {
        currentHitPoint = maxHitPoints;
    }

    void OnParticleCollision(GameObject other)
    {
        currentHitPoint--;
        if (currentHitPoint < 1)
        {
            gameObject.SetActive(false);
        }
    }
}
