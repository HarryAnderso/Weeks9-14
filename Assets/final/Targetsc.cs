using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targetsc : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve curven;
    public Sprite rtg;
    public Sprite grtg;
    public Sprite gotg;
    public int freq;
    public float t;
    public bool shot;
    public float l;
    public bool down;
    public bool recov;
    public float v;
    public bool green;
    public Image image;
    public bool bonust;
   //
   //public Button shootdown;
    
    void Start()
    {
        //setting up the rate at which targets switch to green
        freq = Random.Range(1, 8);
        shot = false;
        down = false;
        //setting the defualt image sprite to the red basic target
        image.sprite = rtg;
        //Recoversoon();
        //StartCoroutine(Recoversoon());
        //shootdown.onClick.AddListener( );

    }

    public void knock()
    {
        //calls the coroutine
        StartCoroutine(Recoversoon());
    }

    // Update is called once per frame
    void Update()
    {
        //this checks to make sure the target has actually been hit
        if(shot == true)
        {
            
            {
                //this section deals with rotating the target out of existence
                t = t + Time.deltaTime;
                Vector3 notreal = transform.eulerAngles;
                notreal.x = notreal.x + (Time.deltaTime * curven.Evaluate(t)) * 500;
                //notreal.x = notreal.x + Time.deltaTime*10;
                transform.eulerAngles = notreal;
                //Debug.Log("flipping");
                if (transform.eulerAngles.x >= 90)
                {
                    shot = false;
                    freq = freq - 1;
                    t = 0;
                    down = true;
                    //calls the coroutine
                    knock();
                }
            }

        }
        //set to true at the end of the coroutine, this makes sure that none of the conidtions that interfere with normal rotating are met
        if(recov == true)
        {
            if(freq == 0)
            {
                green = true;
                freq = Random.Range(1, 8);
                image.sprite = grtg;
            }
            if(bonust == true)
            {
                image.sprite = gotg;
            }




            v = v + Time.deltaTime;
            Vector3 notreal = transform.eulerAngles;
            //rotates the target back in
            notreal.x = notreal.x - (Time.deltaTime * curven.Evaluate(v)) * 500;
            //notreal.x = notreal.x + Time.deltaTime*10;
            transform.eulerAngles = notreal;
            Debug.Log("figured out");
            //checks to make sure the target has reached it goal
            if (notreal.x<=0)
            {
                Debug.Log("HEre it is");
                recov = false;
                notreal.x = 0;
                transform.eulerAngles = notreal;
                v = 0;
            }
        }

    }
    //this coroutine is for the in between period between rotating out and rotating in
    IEnumerator Recoversoon()
    {
        //Debug.Log("haha");
        while (down == true)
        {
            l = l + Time.deltaTime;
            yield return null;
            if (l>5)
            {
                l = 0;
                down = false;
                recov = true;
            }
        }
        
    }
    //this class is to inform the script the target has been shot
    public void onceclicked()
    {
        //Vector3 notreal = transform.eulerAngles;
        //notreal.x = notreal.x + Time.deltaTime * curven.Evaluate(t);
        //notreal.x = notreal.x + Time.deltaTime;
        //transform.eulerAngles = notreal;
        Debug.Log("haha");
        shot = true;
    }
    //this was supposed to be for respawning  the target as green but I couldnt figure out the proper trigger for the gold targets
    public void greenclick()
    {
        if (green == true)
        {
            green = false;
            image.sprite = rtg;
            bonust = true;
            shot = true;
        }

    }
    //this was supposed to be called for other targets when the green target was shot but I could'nt figure it out
    public void bonus()
    {
        bonust = true;
    }
    //Same as before, this was another attempt to use listeners but I couldnt figure it out 
    public void spawngold()
    {
        //this would have been used to swap the sprite to the golden one once called
        image.sprite = gotg;
        //this rotates the function out so the gold target can rotat back in
        t = t + Time.deltaTime;
        Vector3 notreal = transform.eulerAngles;
        notreal.x = notreal.x + (Time.deltaTime * curven.Evaluate(t)) * 500;
        //notreal.x = notreal.x + Time.deltaTime*10;
        transform.eulerAngles = notreal;
        if (transform.eulerAngles.x >= 90)
        {
            //shot = false;
            //freq = freq - 1;
            t = 0;
            down = true;
            knock();
        }
    }
}
