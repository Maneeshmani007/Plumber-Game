using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapScript : MonoBehaviour
{
    public bool Iscorutine = false;
    public GameObject filled;
    //public PipeConnectionManager pipemanager
    [SerializeField]
    //private int totalPipes;
    private int connectedCount;
    private int InitialCount;

    // Start is called before the first frame update
    void Start()
    {
        GlobalClass.DetectionCount = connectedCount;
        InitialCount = FindFirstObjectByType<PipeConnectionManager>().totalPipes;
        Debug.Log("num of count start" + connectedCount);
        Debug.Log("num of count tottalpipes" + InitialCount);

        //connectedCount = totalPipes;

        //StartCoroutine(CheckGameStatus());



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Snap"))
        {
            
            Debug.Log("snapeddd");
            GlobalClass.DetectionCount++;
            if (GlobalClass.DetectionCount == InitialCount)
            {
                Debug.Log("GameWOn");

            }

            Debug.Log("count num" + GlobalClass.DetectionCount);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Snap"))
        {

            Debug.Log("snapeddd");
            GlobalClass.DetectionCount--;
            

            Debug.Log("count num  22 " + GlobalClass.DetectionCount);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Snap"))
        {
            
            filled.SetActive(true);
           

        }
        else
        {

            filled.SetActive(false);
        }
    }


    public void CheckWOn()
    {
        
    }

    public IEnumerator CheckGameStatus()
    {


        while (false)
        {
            yield return new WaitForSeconds(1f); // Adjust the interval based on your needs.
            CheckPipes();

        }


    }

    public void CheckPipes()
    {


        TileCollider[] pipes = FindObjectsOfType<TileCollider>();

        int connectedCount = 0;
        Debug.Log("snapeddd CHECK 3");
        foreach (TileCollider pipe in pipes)
        {
            if (pipe.isConnected)
            {

                connectedCount++;
                Debug.Log("count" + connectedCount);
            }


            if (connectedCount == InitialCount)
            {
                Debug.Log("Game Won!");
                // Handle game won logic here.
            }
        }

       
    }
}
