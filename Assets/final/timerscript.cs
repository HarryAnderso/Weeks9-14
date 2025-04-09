using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerscript : MonoBehaviour
{
    
    public TextMeshProUGUI scorenum;
    public float timeed;
    public int seconds;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this increases time 
        timeed = timeed + Time.deltaTime;
        //Debug.Log(timeed);
        //this is just so that the timer doesnt display 1000 numbers and just sticsk to whole seconds
        if(timeed>=1)
        {
            timeed = 0;
            seconds = seconds + 1;
        }
        //updates the text in the timer to the seconds
        scorenum.text = seconds.ToString();
    }
}
