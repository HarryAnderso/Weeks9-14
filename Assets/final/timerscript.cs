using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerscript : MonoBehaviour
{
    
    public TextMeshProUGUI scorenum;
    public float timeed;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = timeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeed = timeed + Time.deltaTime;
        Debug.Log(timeed);
        scorenum.text = timeed.ToString();
    }
}
