using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDistroy : MonoBehaviour
{
    void Start()
    {
        // Ensure that this GameObject persists across scenes
        DontDestroyOnLoad(this.gameObject);
    }
}
