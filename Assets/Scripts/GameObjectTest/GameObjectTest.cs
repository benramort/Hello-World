using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{

    Vector3 posicionAnterior;

    // Start is called before the first frame update
    void Start()
    {
        posicionAnterior = transform.position;
        GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        if (transform.position != posicionAnterior)
        {
            Debug.Log("Posición: " + transform.position);
            posicionAnterior = transform.position;
        }
    }
}
