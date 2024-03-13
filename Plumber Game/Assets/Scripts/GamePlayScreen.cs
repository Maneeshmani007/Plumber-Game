using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayScreen : MonoBehaviour
{
    public static GamePlayScreen _instance;




    public GameObject Base;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void ExitScreen()
    {
        //base.ExitScreen();
        Base.SetActive(false);
        //Updated = false;
    }
    public  void InitScreen()
    {
        //base.InitScreen();
        Base.SetActive(true);
        //Updated = true;

    }
}
