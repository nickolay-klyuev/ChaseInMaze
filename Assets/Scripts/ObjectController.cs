using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Material selectedMaterial;
    public Material defaultMaterial;

    private float xTarget;
    private float zTarget;
    public void SetTarget(float x, float z)
    {
        xTarget = x;
        zTarget = z;
    }

    private bool isSelected = false;
    public void SetIsSelected(bool selected)
    {  
        isSelected = selected;
    }

    public bool GetIsSelected()
    {
        return isSelected;
    }
    
    private bool isChasing = false;
    public void SetIsChasing(bool chasing)
    {
        isChasing = chasing;
    }

    private GameObject enemyForChasing;

    // Start is called before the first frame update
    void Start()
    {
        xTarget = transform.position.x;
        zTarget = transform.position.z;

        GetComponent<MeshRenderer>().material = defaultMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraForward = Camera.main.transform.forward * Time.deltaTime * moveSpeed;
        Vector3 cameraRight = Camera.main.transform.right * Time.deltaTime * moveSpeed;
        Vector3 adaptiveCameraForward = new Vector3(cameraForward.x, 0, cameraForward.z);
        Vector3 adaptiveCameraRight = new Vector3(cameraRight.x, 0, cameraRight.z);

        if (Input.GetButton("Up"))
        {
            transform.position = transform.position + adaptiveCameraForward;
        }
        if (Input.GetButton("Down"))
        {
            transform.position = transform.position - adaptiveCameraForward;
        }
        if (Input.GetButton("Right"))
        {
            transform.position = transform.position + adaptiveCameraRight;
        }
        if (Input.GetButton("Left"))
        {
            transform.position = transform.position - adaptiveCameraRight;
        }

        transform.eulerAngles = new Vector3(0, Camera.main.transform.rotation.eulerAngles.y, 0);

        /*if (isChasing)
        {
            xTarget = enemyForChasing.transform.position.x;
            zTarget = enemyForChasing.transform.position.z;
        }
        float step = moveSpeed * Time.deltaTime;
        Vector3 target = new Vector3(xTarget, transform.position.y, zTarget);
        transform.position = Vector3.MoveTowards(transform.position, target, step);

        if (isSelected)
        {
            ChangeMaterial("selected");
        }*/
    }

    void OnMouseDown()
    {
        isSelected = true;
    }

    public void ChaseEnemy(GameObject enemy)
    {
        SetIsChasing(true);
        enemyForChasing = enemy;
    }

    public void ChangeMaterial(string materialType = "default")
    {
        if (materialType == "selected")
        {
            GetComponent<MeshRenderer>().material = selectedMaterial;
        }
        else
        {
            GetComponent<MeshRenderer>().material = defaultMaterial;
        }
    }
}
