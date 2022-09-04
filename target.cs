using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public GameObject goal;

    void Start() 
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグ
        if (other.CompareTag("Blue"))
        {
            //オブジェクトの色を変更する
            GetComponent<Renderer>().material.color = Color.white;
            goal.GetComponent<Renderer>().material.color = Color.green;
            goal.tag = "valid_goal";
        }
    }
}
