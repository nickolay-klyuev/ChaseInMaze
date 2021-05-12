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
        Transform parent = transform.parent.transform;

        if (Input.GetMouseButtonDown(0))
        {
            parent.GetComponent<Animator>().SetTrigger("WeaponHitTrigger");
        }

        if (parent.localEulerAngles.y >= 90 && parent.localEulerAngles.y <= 270)
        {
            EnabledComponents(true);
        }
        else
        {
            EnabledComponents(false);
        }
    }

    void EnabledComponents(bool isEnabled)
    {
        gameObject.GetComponent<BoxCollider>().enabled = isEnabled;
        gameObject.GetComponent<MeshRenderer>().enabled = isEnabled;
    }
}
