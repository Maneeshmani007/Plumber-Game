using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject TilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
               GameObject gm= Instantiate(TilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                gm.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
