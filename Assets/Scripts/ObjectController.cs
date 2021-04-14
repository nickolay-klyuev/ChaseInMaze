using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float xTarget = 10;
    public float zTarget = 15;

    public Material selectedMaterial;
    public Material defaultMaterial;

    private bool isSelected = false;
    private bool isChasing = false;
    private GameObject enemyForChasing;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material = defaultMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
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
        }
    }

    void OnMouseDown()
    {
        isSelected = true;
    }

    public void SetIsSelected(bool selected)
    {  
        isSelected = selected;
    }

    public bool GetIsSelected()
    {
        return isSelected;
    }

    public void ChaseEnemy(GameObject enemy)
    {
        SetIsChasing(true);
        enemyForChasing = enemy;
    }

    public void SetIsChasing(bool chasing)
    {
        isChasing = chasing;
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
