using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public TextMeshProUGUI endscore;

    public float timeStart = 60;
    public GameObject canvasIngame;
    public GameObject canvasEndscreen;

    private float time;

    void Start()
    {
        time = timeStart;
        canvasEndscreen.SetActive(false);
        canvasIngame.SetActive(true);
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
            canvasIngame.SetActive(false);
            canvasEndscreen.SetActive(true);
            int showResult = PlayerController.collisionToScore;

            endscore.text = "Your Score is " + showResult.ToString() + "!";

           
        }

        


    }

    public void RestartGame()
    {
        PlayerController.collisionToScore = 0;
        SceneManager.LoadScene("MainScene");
        
    }


}
