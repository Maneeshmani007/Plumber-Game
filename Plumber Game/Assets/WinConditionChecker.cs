using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionChecker : MonoBehaviour
{

    public static WinConditionChecker instance;
    public GameOverScreen Gameover;

    public bool gameWon = false;
    public static bool win1;
    public static bool win2;
    public static bool win3;
    public static bool win4;



    // Start is called before the first frame update
    void Start()
    {
        gameWon = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameWon == true) return;
        if (win1 && win2 && win3 && win4)
        {

            Debug.Log("won the game");
            gameWon = true;
            GameOverScreen.instance.InitScreen();
            GameOverScreen.instance.WIN();
           

            //Debug.Log("won the game");
        }
        else
        {
            gameWon = false;
        }

    }
}
