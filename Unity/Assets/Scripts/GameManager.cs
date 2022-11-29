using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
 
    [SerializeField]
    GameObject Render1;
    [SerializeField]
    GameObject Render2;
    [SerializeField]
    bool R1, v1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (R1)
        {
            v1 = !v1;
            Render1.SetActive(v1);
        }
    }
}
