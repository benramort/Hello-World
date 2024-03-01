using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum Tags
//{
//    Colorable,
//    Respawn
//}

public class PaintObjectsGlobal : MonoBehaviour
{
    //public string tagName = Tags.Respawn;
    public string tagName;
    public bool useTag;
    public Color color;

    private Color previousColor;
    private bool previousUseTag;
    private GameObject[] golist;
    private MeshRenderer[] meshList;

    // Start is called before the first frame update
    void Start()
    {
        previousUseTag = !useTag;
        golist = GameObject.FindGameObjectsWithTag(tagName);
        meshList = FindObjectsOfType<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckRepaint();
    }

    private void CheckRepaint()
    {
        if (previousColor != color)
        {
            previousColor = color;
            repaint();
        }
        else if (previousUseTag != useTag)
        {
            previousUseTag = useTag;
            repaint();
        }
    }

    void repaint()
    {
        if (useTag)
        {
            foreach (GameObject go in golist)
            {
                go.GetComponent<MeshRenderer>().material.color = color;
            }
        }
        else
        {

            foreach (MeshRenderer mr in meshList)
            {
                mr.material.color = color;
            }
        }
    }
}
