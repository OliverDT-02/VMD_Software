using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform LampOrientation;

    // Update is called once per frame
    void Update()
    {

        transform.rotation = LampOrientation.rotation;
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
    }
}
