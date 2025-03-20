using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Clickspawn : MonoBehaviour
{
    public GameObject houselevel;
    public GameObject roof;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
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
            Instantiate(houselevel, fakepos, transform.rotation);
            fakepos.y = fakepos.y + .75f;
            Instantiate(roof, fakepos, transform.rotation);
            fakepos.y = fakepos.y - 1f;
            Instantiate(door, fakepos, transform.rotation);

        }
    }
    void onclick()
    {
        

    }
}
