using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float enemyMoveSpeed = 2f;

    private bool isMoving = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.rotation.x) > 0.2f || Mathf.Abs(transform.rotation.z) > 0.2f)
        {
            isMoving = false;
        }

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, -10),
                                                    enemyMoveSpeed * Time.deltaTime);
        }
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