using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScreen : Screenbase
{
    public static MenuScreen Insttance;


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
     
            ExitScreen();
            SceneManager.LoadScene("MenuScene");
            Debug.Log("playWorked");

        }
        else if (_button.name == "")
        {

        }
    }
    public new virtual void ExitScreen()
    {
        baseObj.SetActive(false);
        base.ExitScreen();
    }
    public new virtual void InitScreen()
    {
        baseObj.SetActive(false);
        base.InitScreen();
    }
}
