using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollider : MonoBehaviour
{
    public bool isConnected = false;
    public int pipeID; // Unique identifier for each pipe.

    void OnMouseDown()
    {
        // Rotate the pipe on click.
        if (!isConnected)
            SetConnected(false);
    }

    void RotatePipe()
    {
        ////transform.Rotate(0, 0, 90); // Rotate the pipe by 90 degrees.
    }

    public void SetConnected(bool value)
    {
        isConnected = value;
    }
}
