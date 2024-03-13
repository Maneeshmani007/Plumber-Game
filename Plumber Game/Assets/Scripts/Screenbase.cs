using System;
using UnityEngine;
using UnityEngine.UI;

public class Screenbase : MonoBehaviour
{
    public GameObject baseObj;
    public bool Updated = true;
    


    // Start is called before the first frame update
    void Start()
    {
        
            

    }
    private void Awake()
    {
        if (Updated)
        {
            baseObj.SetActive(false);
            Debug.Log("starterd");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void ButtonClick(Button _button)
    {
        
    }

    public virtual void ExitScreen()
    {
        //baseObj.SetActive(false);
        Updated = false;
    }

    public virtual void InitScreen()
    {
        //baseObj.SetActive(true);
        Updated = true;

    }
}
