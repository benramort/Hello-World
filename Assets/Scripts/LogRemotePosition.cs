using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRemotePosition : MonoBehaviour
{
    [SerializeField]
    private GameObject otherGameObject;
    public Vector3 posicionAnterior;

    // Start is called before the first frame update
    void Start()
    {
        //otherGameObject = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
    }

    private void LogPosition()
    {
        if (otherGameObject.transform.position != posicionAnterior)
        {
            Debug.Log("Posición: " + otherGameObject.transform.position);
            posicionAnterior = otherGameObject.transform.position;
        }
    }


}
