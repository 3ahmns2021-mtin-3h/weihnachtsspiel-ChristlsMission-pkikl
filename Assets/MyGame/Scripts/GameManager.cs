using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timer;

    public float timeStart = 60;

    private float time;

    void Start()
    {
        time = timeStart;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        if(time > 0)
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            SceneManager.LoadScene("MainScene");
        }

       
    }
}
