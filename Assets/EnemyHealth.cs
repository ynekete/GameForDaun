using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float HP = 10;

    public void AddDamage(float damage)
    {
        if (HP <= 0)
        HP -= damage;
        {
            Destroy(gameObject);
        }
    }
}
