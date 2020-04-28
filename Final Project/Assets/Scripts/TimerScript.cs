using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    private int StartTime = 30;
    private float currentTime = 0;
    public Text timerSeconds;
    int time = 0;

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            PlayerPrefs.SetInt("Time", StartTime);
            currentTime = PlayerPrefs.GetInt("Time");
        }
        else
        {
            currentTime = PlayerPrefs.GetInt("Time") + 15;
        }
        Debug.Log("tIME: " + currentTime);
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        time = (int)currentTime;
        PlayerPrefs.SetInt("Time", time);
        timerSeconds.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            timerEnded();
        }
    }

    private void timerEnded()
    {
        SceneManager.LoadScene("Gameover");
    }
}
