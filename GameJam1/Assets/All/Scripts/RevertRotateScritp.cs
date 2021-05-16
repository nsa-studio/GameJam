using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertRotateScritp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(0,2,0);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(0,-2,0);
            
        }
    }
}
