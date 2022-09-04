using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public int flag = 0;
    void Start() 
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Blue"))
        {
            if (this.CompareTag("valid_goal"))
           {
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}
