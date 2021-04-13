using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    private ObjectController[] objectControllers;

    // Start is called before the first frame update
    void Start()
    {
        objectControllers = GameObject.FindObjectsOfType<ObjectController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    { 
        foreach(ObjectController objectController in objectControllers)
        {
            objectController.ChangeMaterial();
            objectController.SetIsSelected(false);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            float yCamera = Camera.main.transform.position.y;
            Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, yCamera));

            foreach(ObjectController objectController in objectControllers)
            {
                if (objectController.GetIsSelected())
                {
                    objectController.xTarget = target.x;
                    objectController.zTarget = target.z;
                }
            }
        }
    }
}
