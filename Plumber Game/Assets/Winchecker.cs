using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winchecker : MonoBehaviour
{

    public Vector3 Position1;
    public int Id;
    public GameObject Water;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position==Position1)
        {
            if (Id == 1)
            {
                Water.SetActive(true);
                WinConditionChecker.win1 = true;
            }
            else if (Id == 2)
            {
                Water.SetActive(true);
                WinConditionChecker.win2 = true;
            }
            else if (Id == 3)
            {
                Water.SetActive(true);
                WinConditionChecker.win3 = true;
            }
            else if (Id == 4)
            {
                Water.SetActive(true);
                WinConditionChecker.win4 = true;
            }
        }
        else
        {
            if (Id == 1)
            {
                Water.SetActive(false);
                WinConditionChecker.win1 = false;
            }
            else if (Id == 2)
            {
                Water.SetActive(false);
                WinConditionChecker.win2 = false;
            }
            else if (Id == 3)
            {
                Water.SetActive(false);
                WinConditionChecker.win3 = false;
            }
            else if (Id == 4)
            {
                Water.SetActive(true);
                WinConditionChecker.win4 = false;
            }
        }
       
    }
}
