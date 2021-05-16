using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private string _horizontalAxis = "Horizontal";
    [SerializeField] private string _verticallAxis = "Vertical";


    private Vector3 _inputAxis;

    public static Action<Vector3> OnInput;
    
    //public UnityEvent OnInput;
    
    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        _inputAxis.Set(horizontal, 0, vertical);
        
        OnInput?.Invoke(_inputAxis);
        
    }
}
