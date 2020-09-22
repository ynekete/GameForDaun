using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float damage = 1;
    public float timeout = 0.2f;
    public string[] targetTags = { "Target_1" };
    private float curTimeout;

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        curTimeout += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit))
            {
                if (curTimeout > timeout)
                {
                    curTimeout = 0;
                    Debug.DrawRay(gameObject.transform.position, transform.forward * hit.distance, Color.red);
                    hit.transform.GetComponent<EnemyHealth>().AddDamage(damage);
                    Debug.Log("damage");
                }
            }
        }
    }
}
