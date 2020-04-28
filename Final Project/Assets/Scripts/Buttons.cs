using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    int index = 1;
    int time = 0;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            Debug.Log("Collision Detected");
            Debug.Log("Win");
            Win();
        }
    }
   
    public void NextGame()
    {
        float waitTime = 4;
        float counter = 0;
        while (counter < waitTime)
        {
            counter += Time.deltaTime;
            Debug.Log(counter);
        }
        index = PlayerPrefs.GetInt("Score");
        if (index + 1 > 5)
        {
            PlayerPrefs.SetInt("Score", 1);
            SceneManager.LoadScene("Win");
        }
        else
        {
            SceneManager.LoadScene(index + 1);
        }
    }

    public void Back()
    {
        float waitTime = 4;
        float counter = 0;
        while (counter < waitTime)
        {
            counter += Time.deltaTime;
        }

        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        float waitTime = 4;
        float counter = 0;
        while (counter < waitTime)
        {
            counter += Time.deltaTime;
            Debug.Log(counter);
        }

        PlayerPrefs.SetInt("Score", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Gameover");
    }

    public void Win()
    {
        float waitTime = 4;
        float counter = 0;
        while (counter < waitTime)
        {
            counter += Time.deltaTime;
            Debug.Log(counter);
        }
        Debug.Log(index);
        PlayerPrefs.SetInt("Score", SceneManager.GetActiveScene().buildIndex);
        if (index < 4)
        {
            SceneManager.LoadScene("Next");
        }
        else
        {
            SceneManager.LoadScene("Win");
        }
    }

    public void ReplayGame()
    {
        index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
