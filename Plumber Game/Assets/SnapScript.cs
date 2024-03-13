using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapScript : PipeConnectionManager
{
    public bool Iscorutine = false;
    public GameObject filled;
    //public PipeConnectionManager pipemanager
    [SerializeField]
    //private int totalPipes;
    private int connectedCount;

    // Start is called before the first frame update
    void Start()
    {

        //connectedCount = totalPipes;

        //StartCoroutine(CheckGameStatus());



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Snap")&& !Iscorutine)
        {
            Iscorutine = true;
            filled.SetActive(true);
            Debug.Log("snapeddd");
            TileCollider[] pipes = FindObjectsOfType<TileCollider>();
            foreach (TileCollider Pipe in pipes)
            {
                connectedCount++;
                Debug.Log("count" + connectedCount);
                //if (Pipe.isConnected)
                //{

                   
                //    Debug.Log("count" + connectedCount);
                //}
              

            }
            
            //Debug.Log("countnum" + connectedCount);
            //if (connectedCount == totalPipes)
            //{
            //    Debug.Log("Game Won!");
            //    // Handle game won logic here.
            //}

            //CheckPipes();
            //TileCollider[] t = FindObjectsOfType<TileCollider>();
            //foreach(TileCollider T in t)
            //{
            //    T.isConnected = true;
            //    if (T.isConnected)
            //    {
            //        StartCoroutine(CheckGameStatus());
            //    }

            //}



        }
        else
        {
            filled.SetActive(false);
        }
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


            if (connectedCount == totalPipes)
            {
                Debug.Log("Game Won!");
                // Handle game won logic here.
            }
        }

        //if (connectedCount == totalPipes)
        //{
        //    Debug.Log("Game Won!");
        //    // Handle game won logic here.
        //}
    }
}
