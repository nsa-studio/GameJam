using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    private Rigidbody platformRb;
    
    // Start is called before the first frame update
    void Start()
    {
        platformRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(0,-1,0);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.Rotate(0,1,0);
        }
    }
   
}
