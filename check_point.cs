using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_point : MonoBehaviour
{
    public int step;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        step = 0;
     	pos = new Vector3(-10.0f,6.0f,0.0f); 
		transform.position = pos;   
    }

    void OnTriggerEnter(Collider other)
    {
        //接触したオブジェクトのタグ
        if (other.CompareTag("range"))
        {
            step++;
        }

        if (step == 1)
        {
            pos.x = 4.4f;
            transform.position = pos;
        }

        if (step == 2)
        {
            pos.y = -5.0f;
            transform.position = pos;
        }

        if (step == 3)
        {
            pos.x = 13.0f;
            pos.y = -6.0f;
            transform.position = pos;
        }
    }
}
