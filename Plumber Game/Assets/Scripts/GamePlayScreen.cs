using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayScreen : MonoBehaviour
{
    public static GamePlayScreen _instance;


    public static GamePlayScreen instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GamePlayScreen>();
            }
            return _instance;
        }
    }




    public GameObject Base;


    private GameOverScreen Gameover;

    public float countdownTime = 60f;
    public Text timerText;
    private float currentTime;
    private bool timerIsRunning = false;


    private void Awake()
    {
        _instance = this;
        Time.timeScale = 1;


    }

    // Start is called before the first frame update
    void Start()
    {

        //Gameover = FindObjectOfType<GameOverScreen>();
        timerIsRunning = true;
        currentTime = countdownTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning == false) return;

        currentTime -= Time.deltaTime;
        currentTime = Mathf.Clamp(currentTime, 0f, Mathf.Infinity);
        UpdateTimerText();


        if (currentTime <= 0f)
        {


            //Gameover.InitScreen(false);
            timerIsRunning = false;
            currentTime = countdownTime;
            
            ExitScreen();
            GameOverScreen.instance.InitScreen();
            GameOverScreen.instance.FAILED();
           


        }
        else
        {

        }



    }

    void UpdateTimerText()
    {
        if (timerIsRunning == false) return;

        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        if (timerText != null)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void ButtonClick(Button _button)
    {

        if (_button.name == "RESET BTN")
        {

            ReloadScene();
        }
        else if (_button.name == "")
        {

        }
    }



    public void ExitScreen()
    {
        Base.SetActive(false);

    }
    public void InitScreen()
    {
        Base.SetActive(true);

    }


    public void ReloadScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
