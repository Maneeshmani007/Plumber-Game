using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public static GameOverScreen _instance;

    public static GameOverScreen instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameOverScreen>();
            }
            return _instance;
        }
    }

    public GameObject BaseObj;

    public bool Updates = false;

    public GameObject GAMEWON;
    public GameObject GAMEFAILED;
    public GameObject MAinmenubtn;
    public GameObject PlayBTin;
    public GameObject reet;
    public GameObject Bg;

    public WinConditionChecker wincondition;



    private void Awake()
    {
        _instance = this;
        Initgame();
       
        Time.timeScale = 1;

        //bu
       

    }

    private void Initgame()
    {
        GAMEWON.SetActive(false);
        GAMEFAILED.SetActive(false);
        MAinmenubtn.SetActive(false);
        PlayBTin.SetActive(false);
        Bg.SetActive(false);
        reet.SetActive(false);

        StartCoroutine(InitialUpdate());
    }

    // Start is called before the first frame update
    void Start()
    {

        Initgame();
        //ExitScreen();
        //Time.timeScale = 1;

        //bu
        //ReloadScene();

    }

    private void OnDisable()
    {
        BaseObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void WIN()
    {
        GAMEWON.SetActive(true);
        GAMEFAILED.SetActive(false);
        MAinmenubtn.SetActive(true);
        PlayBTin.SetActive(true);
        Bg.SetActive(true);
    }
    public void FAILED()
    {
        GAMEWON.SetActive(false);
        GAMEFAILED.SetActive(true);
        MAinmenubtn.SetActive(true);
        PlayBTin.SetActive(true);
        Bg.SetActive(true);
    }

    public  void ExitScreen()
    {

        
        GAMEWON.SetActive(false);
        GAMEFAILED.SetActive(false);
        MAinmenubtn.SetActive(false);
        PlayBTin.SetActive(false);
        Bg.SetActive(false);

        //BaseObj.SetActive(false);
        
        //Updates = true;

    }

    public void ButtonClick(Button _button)
    {

        if (_button.name == "PlayAgainBTN")
        {
            ExitScreen();
            Time.timeScale = 1;

            //bu
            wincondition.gameWon = false;
            ReloadScene();
        }
        else if (_button.name == "ExitBTN")
        {

            wincondition.gameWon = false;
            ExitScreen();
            Time.timeScale = 1;
            ReloadScene();
            SceneManager.LoadScene("MenuScene");
        }
        else if (_button.name == "MainMenuBTN")
        {
            wincondition.gameWon = false;
            ExitScreen();
            Time.timeScale = 1;
            StartCoroutine(UpdateBeforeEXit());
            //SceneManager.LoadScene("MenuScene");
        }
    }


    public IEnumerator UpdateBeforeEXit()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MenuScene");
    }

    public IEnumerator InitialUpdate()
    {
        yield return new WaitForSeconds(1.5f);
        ExitScreen();

    }



    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(currentSceneIndex);
        //ExitScreen();
    }




    public  void InitScreen()
    {
        //OnScreenLoadComplete();
        //BaseObj.SetActive(true);

        WIN();

    }


    //public void winCheck(bool val)
    //{
    //    if (val == true)
    //    {
    //        WIN();

    //    }
    //    else
    //    {
    //        FAILED();
    //    }
    //}

    public virtual void OnScreenLoadComplete()
    {
        //Updates = true;
    }


}
