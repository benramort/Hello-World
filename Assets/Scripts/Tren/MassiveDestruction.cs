using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassiveDestruction : MonoBehaviour
{

    private Object[] gameObjects;
    private List<Object> gameObjectsList;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindObjectsOfType(typeof(GameObject));
        gameObjectsList = new List<Object>(GameObject.FindObjectsOfType(typeof(GameObject)));
        Debug.Log("Tamaño:" + gameObjectsList.Count);
        gameObjectsList.Remove(gameObjectsList[1]);
        //gameObjectsList.TrimExcess();
        Debug.Log("Tamaño:" + gameObjectsList.Count);
    }

    // Update is called once per frame
    void Update()
    {
        Destruction();
    }

    private void Destruction()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Tamaño:" + gameObjectsList.Count);
            
            int i = Random.Range(0, gameObjectsList.Count);
            GameObject toDestroy = (GameObject) gameObjectsList[i];
            if (toDestroy == null || toDestroy.GetComponent<Camera>() != null || toDestroy == gameObject)
            {
                Debug.Log("No se ha podido destruir");
            }
            else
            {
                gameObjectsList.Remove(toDestroy);
                Destroy(toDestroy);
                Debug.Log("Destruído");
            }
            
        }
    }
}
