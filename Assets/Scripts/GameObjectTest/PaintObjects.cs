using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Colorable");
        foreach (GameObject obj in objects)
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
