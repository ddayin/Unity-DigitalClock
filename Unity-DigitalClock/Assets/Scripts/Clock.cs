using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI hour;
    public TextMeshProUGUI minute;
    public TextMeshProUGUI second;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        DateTime time = DateTime.Now;

        int hourValue = time.Hour;
        int minuteValue = time.Minute;
        int secondValue = time.Second;

        if (hourValue >= 0 && hourValue <= 9) {
            hour.text = "0" + hourValue.ToString();
        } else {
            hour.text = hourValue.ToString();
        }

        if (minuteValue >= 0 && minuteValue <= 9) {
            minute.text = "0" + minuteValue.ToString();
        } else {
            minute.text = minuteValue.ToString();
        }
        
        if (secondValue >= 0 && secondValue <= 9) {
            second.text = "0" + secondValue.ToString();
        } else {
            second.text = secondValue.ToString();
        }
    }
}
