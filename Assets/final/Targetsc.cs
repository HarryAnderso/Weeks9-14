using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targetsc : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve curven;
    public SpriteRenderer rtg;
    public SpriteRenderer grtg;
    public SpriteRenderer gotg;
    public int freq;
    public float t;
    public bool shot;
    
    void Start()
    {
        freq = Random.Range(1, 8);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shot == true)
        {
            t =t+ Time.deltaTime;
            Vector3 notreal = transform.eulerAngles;
            notreal.x = notreal.x + (Time.deltaTime * curven.Evaluate(t))*500;
            //notreal.x = notreal.x + Time.deltaTime*10;
            transform.eulerAngles = notreal;
            Debug.Log("flipping");
            if(transform.eulerAngles.x >= 90)
            {
                shot = false;
            }
        }
    }

    public void onceclicked()
    {
        //Vector3 notreal = transform.eulerAngles;
        //notreal.x = notreal.x + Time.deltaTime * curven.Evaluate(t);
        //notreal.x = notreal.x + Time.deltaTime;
        //transform.eulerAngles = notreal;
        Debug.Log("haha");
        shot = true;
    }
}
