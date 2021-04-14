using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedOfMoving = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButton("Up"))
        {
            transform.position += new Vector3(0, 0, speedOfMoving) * Time.deltaTime;
        }
        if (Input.GetButton("Down"))
        {
            transform.position += new Vector3(0, 0, -speedOfMoving) * Time.deltaTime;
        }
        if (Input.GetButton("Left"))
        {
            transform.position += new Vector3(-speedOfMoving, 0, 0) * Time.deltaTime;
        }
        if (Input.GetButton("Right"))
        {
            transform.position += new Vector3(speedOfMoving, 0, 0) * Time.deltaTime;
        }*/
    }
}
