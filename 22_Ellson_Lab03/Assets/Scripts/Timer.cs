using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int countDownStartValue = 45;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            timerText.text = "Timer: " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            SceneManager.LoadScene("LoseScenes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
