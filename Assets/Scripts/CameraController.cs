using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedOfMoving = 1f;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        transform.position = new Vector3(playerPosition.x, transform.position.y, playerPosition.z);

        float horisontal = speedOfMoving * Input.GetAxis("Mouse X");
        float vertical = speedOfMoving * Input.GetAxis("Mouse Y");

        Vector3 rotateValue = new Vector3(vertical, horisontal * -1, 0f);

        transform.eulerAngles = transform.eulerAngles - rotateValue;

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
