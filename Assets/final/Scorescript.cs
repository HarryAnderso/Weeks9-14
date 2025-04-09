using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scorescript : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //updates the score each frame
        scoretext.text = score.ToString();
    }

    public void increased()
    {
        
        //whenever a target is clicked, this gets triggered and adds to the score
        score = score + 1;
    }
}
