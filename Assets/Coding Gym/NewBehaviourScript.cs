using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float t;
    void Start()
    {
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        t = t + Time.deltaTime;
        if(t>5)
        {
            
        }
    }
}
