using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clickspawn : MonoBehaviour
{
    public GameObject houselevel;
    public GameObject roof;
    public GameObject door;
    public float t;
    public float b;
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        Vector3 testerizing;
        testerizing.x = 1;
        testerizing.z = 0;
        testerizing.y = 1;
        //Instantiate(houselevel, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        bool tf = Input.GetMouseButtonDown(0);
        if(tf == true)
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 fakepos = mouse;
            fakepos.z = 0;
            GameObject fakeh = Instantiate(houselevel, fakepos, transform.rotation);
            fakepos.y = fakepos.y + .75f;
            GameObject faker = Instantiate(roof, fakepos, transform.rotation);
            fakepos.y = fakepos.y - 1f;
            GameObject faked = Instantiate(door, fakepos, transform.rotation);
            Destroy(fakeh, 5);
            Destroy(faker, 5);
            Destroy(faked, 5);

        }
        //t = t + Time.deltaTime;
        //if (t > 5)
        //{
        //    Destroy(roof,5);
        //}
        

    }
    public void Crash()
    {
        StartCoroutine(GetSmaller());
    }

    IEnumerator GetSmaller()
    {
        b = 0;
        while(t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;
            yield return null;
        }
    }


    void onclick()
    {
        

    }
}
