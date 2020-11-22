using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCode : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public float timeRemaining = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            text.text = timeRemaining.ToString();
        }
        else
        {
            
        }
    }
}

