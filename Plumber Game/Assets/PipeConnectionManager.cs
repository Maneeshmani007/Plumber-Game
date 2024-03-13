using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PipeConnectionManager : MonoBehaviour
{
    public static PipeConnectionManager _instace;


    public int totalPipes; // Set the total number of pipes in the inspector.
    private int connectedPipes = 0;

    void Start()
    {
        //StartCoroutine(CheckGameStatus());
    }

    public IEnumerator CheckGameStatus1()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); // Adjust the interval based on your needs.
            //CheckPipes();
        }
    }

    public void CheckPipes1()
    {

        TileCollider[] pipes = FindObjectsOfType<TileCollider>();

        int connectedCount = 0;

        foreach (TileCollider pipe in pipes)
        {
            if (pipe.isConnected)
            {
                Debug.Log("matched1");
                connectedCount++;
            }
        }

        if (connectedCount == totalPipes)
        {
            Debug.Log("Game Won!");
            // Handle game won logic here.
        }
    }
}
