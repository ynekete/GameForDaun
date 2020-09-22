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
        if (Input.GetMouseButton(0))
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(gameObject.transform.position,transform.forward * hit.distance, Color.red);
                curTimeout += Time.deltaTime;
                if (curTimeout > timeout)
                {                 
                    curTimeout = 0;
                    hit.transform.GetComponent<EnemyHealth>().AddDamage(damage);
                    Debug.Log("damage");
                }
            }
    }

}
