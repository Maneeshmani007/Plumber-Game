using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : Screenbase
{
    public static GameOverScreen _instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
