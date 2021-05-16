using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBox : MonoBehaviour
{
    public Rigidbody body = null;

    private void Start()
    {
        this.body = this.GetComponent<Rigidbody>() ?? this.gameObject.AddComponent<Rigidbody>();
        
    }
}
