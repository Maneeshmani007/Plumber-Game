using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectioScreen : Screenbase
{
    public static LevelSelectioScreen INSTANCE;
    public GameObject baseOb1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void ButtonClick(Button _button)
    {

        if (_button.name == "PLAYBTN")
        {
            //GamePlayScreen._instance.InitScreen();
            ExitScreen();
            SceneManager.LoadScene("GamePlayScene");
            GamePlayScreen._instance.InitScreen();
            
            

        }
        else if (_button.name == "PLAYBTN (1)")
        {
            ExitScreen();
            SceneManager.LoadScene("GamePlayScene 1");
            GamePlayScreen._instance.InitScreen();
        }
        else if (_button.name == "PLAYBTN (2)")
        {

            ExitScreen();
            SceneManager.LoadScene("GamePlayScene 2");
            GamePlayScreen._instance.InitScreen();
        }


    }
    public new virtual void ExitScreen()
    {
        baseOb1.SetActive(false);
        base.ExitScreen();
    }
    public new virtual void InitScreen()
    {
        baseOb1.SetActive(false);

    }
}
