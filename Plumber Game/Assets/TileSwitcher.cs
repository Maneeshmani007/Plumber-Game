using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSwitcher : MonoBehaviour
{
    bool hasClickedTile;

    Vector3 position1;
    Vector3 position2;

    GameObject Tile1;
    GameObject Tile2;
    GameObject HoverTileCopy;
    PipeConnectionManager PR;
    // Start is called before the first frame update
    void Start()
    {
        hasClickedTile = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            try
            {
                if (hit.collider.CompareTag("Tile"))
                {

                    hasClickedTile = true;
                    Tile1 = hit.collider.gameObject;
                    position1 = hit.collider.transform.position;

                    HoverTileCopy = Instantiate(Tile1, transform.position, Quaternion.identity);
                    HoverTileCopy.GetComponent<BoxCollider2D>().enabled = false;
                    HoverTileCopy.GetComponent<SpriteRenderer>().sortingOrder = 10;
                    
                    Tile1.GetComponent<SpriteRenderer>().enabled = false;
                }
                else
                {
                    hasClickedTile = false;
                }
            }
            catch (Exception e)
            {

            }




        }

        if (Input.GetMouseButtonUp(0) && hasClickedTile)
        {
            hasClickedTile = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Tile"))
                {

                    Tile2 = hit.collider.gameObject;
                    position2 = hit.collider.transform.position;

                    Tile2.transform.position = position1;
                    Tile1.transform.position = position2;
                   
                }
            }

            if (HoverTileCopy != null)
            {
                Destroy(HoverTileCopy);

            }

            if (Tile1 != null)
            {
                Tile1.GetComponent<SpriteRenderer>().enabled = true;
            }
        }

        if (hasClickedTile == true && HoverTileCopy != null)
        {
            HoverTileCopy.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        }






        //touch input

        //// Check for touch beginning
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        //    try
        //    {
        //        if (hit.collider.CompareTag("Tile"))
        //        {
        //            hasClickedTile = true;
        //            Tile1 = hit.collider.gameObject;
        //            position1 = hit.collider.transform.position;

        //            HoverTileCopy = Instantiate(Tile1, transform.position, Quaternion.identity);
        //            HoverTileCopy.GetComponent<BoxCollider2D>().enabled = false;
        //            HoverTileCopy.GetComponent<SpriteRenderer>().sortingOrder = 10;

        //            Tile1.GetComponent<SpriteRenderer>().enabled = false;
        //        }
        //        else
        //        {
        //            hasClickedTile = false;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        // Handle exceptions if needed
        //    }
        //}

        //// Check for touch release
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended && hasClickedTile)
        //{
        //    hasClickedTile = false;
        //    Touch touch = Input.GetTouch(0);

        //    Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //    RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

        //    if (hit.collider != null)
        //    {
        //        if (hit.collider.CompareTag("Tile"))
        //        {
        //            GameObject Tile2 = hit.collider.gameObject;
        //            Vector3 position2 = hit.collider.transform.position;

        //            Tile2.transform.position = position1;
        //            Tile1.transform.position = position2;
        //        }
        //    }

        //    if (HoverTileCopy != null)
        //    {
        //        Destroy(HoverTileCopy);
        //    }

        //    if (Tile1 != null)
        //    {
        //        Tile1.GetComponent<SpriteRenderer>().enabled = true;
        //    }
        //}

        //// Check for ongoing touch movement
        //if (hasClickedTile && HoverTileCopy != null)
        //{
        //    Touch touch = Input.GetTouch(0);
        //    HoverTileCopy.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(touch.position).x, Camera.main.ScreenToWorldPoint(touch.position).y, 0);
        //}




    }
}
