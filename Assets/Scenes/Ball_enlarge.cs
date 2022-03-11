using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_enlarge : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().Play("Bal");
        }
       
    }
}
