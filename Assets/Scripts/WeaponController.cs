using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EnabledComponents(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("works ");
        }
    }

    void EnabledComponents(bool isEnabled)
    {
        gameObject.GetComponent<BoxCollider>().enabled = isEnabled;
        gameObject.GetComponent<MeshRenderer>().enabled = isEnabled;
    }
}
