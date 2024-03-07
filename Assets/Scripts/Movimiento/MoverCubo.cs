using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCubo : MonoBehaviour
{

    public int velocity = 10;
    public int rotateVelocity = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(transform, transform.position, transform.rotation, transform);
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(transform);
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();
        ManageInputAxis();
        ManageInputScale();
        Rotate();
    }

    private void LogPosition()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Posición:" + transform.position);
        }
    }

    private void ManageInput()
    {
        if (Input.GetKey("w"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+velocity*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - velocity * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.position = new Vector3(transform.position.x - velocity * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey("d"))
        {
            transform.position = new Vector3(transform.position.x + velocity * Time.deltaTime, transform.position.y, transform.position.z);
        }

    }

    private void ManageInputAxis()
    {
        transform.position = new Vector3(transform.position.x + velocity * Input.GetAxis("Horizontal") * Time.deltaTime, transform.position.y, transform.position.z + Input.GetAxis("Vertical") * velocity * Time.deltaTime);
        //Debug.Log(Input.GetAxis("Horizontal"));

    }

    private void ManageInputScale()
    {
        if (Input.GetKey("z"))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z + velocity * Time.deltaTime);
        }
        if (Input.GetKey("x"))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z - velocity * Time.deltaTime);
        }
        if (Input.GetKey("c"))
        {
            transform.localScale = new Vector3(transform.localScale.x + velocity * Time.deltaTime, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey("v"))
        {
            transform.localScale = new Vector3(transform.localScale.x - velocity * Time.deltaTime, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey("b"))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y + velocity * Time.deltaTime, transform.localScale.z);
        }
        if (Input.GetKey("n"))
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - velocity * Time.deltaTime, transform.localScale.z);
        }
    }

    private void Rotate()
    {
        //transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y + rotateVelocity * Time.deltaTime, transform.rotation.z, transform.rotation.w);
        //transform.Rotate(new Vector3(0, rotateVelocity*Time.deltaTime, 0));
        transform.rotation *= Quaternion.Euler(0, 1 * rotateVelocity * Time.deltaTime, 0);
    }
}
