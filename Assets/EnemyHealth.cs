using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float HP = 10;

    public void AddDamage(float damage)
    {
        HP -= damage;
        Debug.Log("Text: " + HP);
        if (HP <= 10)
        {
            Destroy(gameObject);
        }
    }
}
