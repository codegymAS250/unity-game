using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class range : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグ
        if (other.CompareTag("wall"))
        {
            //オブジェクトの色を赤に変更する
            GetComponent<Renderer>().material.color = Color.cyan;
            Debug.Log(0);
        }
    }

    void OnTriggerExit(Collider other)
    {
        //接触したオブジェクトのタグ
        if (other.CompareTag("wall"))
        {
            //オブジェクトの色を赤に変更する
            GetComponent<Renderer>().material.color = Color.white;
            Debug.Log(1);
        }
    }
}
