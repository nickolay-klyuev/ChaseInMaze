using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    public float moveSpeed = 1f;

    public float xTarget = 10;
    public float zTarget = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float step = moveSpeed * Time.deltaTime;
        Vector3 target = new Vector3(xTarget, transform.position.y, zTarget);
        transform.position = Vector3.MoveTowards(transform.position, target, step);
    }
}
