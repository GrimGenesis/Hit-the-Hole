using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Rendering;

public class Color : MonoBehaviour
{
    //Renderer sr;
    public Color color;
    int colcount;


    // Start is called before the first frame update
    void Start()
    {
        // sr = GetComponent<Renderer>();
        colcount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        colcount++;
        if (colcount < 2)
        {
            changecol();
        }
    }
    void changecol()
    {
       // transform.GetComponent<Renderer>().material.color ;
    }

}


