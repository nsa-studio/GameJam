using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPlayerScript : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public float horizontalInput;

    [SerializeField] private float force;
    [SerializeField] private float forceSpeed;
    private Vector3 playerVector; 

        // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * (force * Time.deltaTime), ForceMode.Impulse);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * forceSpeed * horizontalInput * Time.deltaTime);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals ("Platform"))
        {
            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Platform"))
        {
            this.transform.parent = null;
        }
    }

}
