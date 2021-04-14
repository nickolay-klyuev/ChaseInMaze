using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(100, transform.position.y, 100), 2f * Time.deltaTime);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            ObjectController[] objectControllers = GameObject.FindObjectsOfType<ObjectController>();
            foreach(ObjectController objectController in objectControllers)
            {
                objectController.ChaseEnemy(gameObject);
            }
        }
    }
}
