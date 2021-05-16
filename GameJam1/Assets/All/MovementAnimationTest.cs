using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

    [RequireComponent(typeof(Animator))]
public class MovementAnimationTest : MonoBehaviour
{
    
    // Start is called before the first frame update
    [Header("Animator params")]
    [SerializeField] private string _runParamName = "Speed_f";
    [SerializeField] private string _jump = "Jump_b";

    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetFloat(_runParamName,3.0f);
        }if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool(_jump,true);
        }

        if (!Input.anyKey)
        {
            _animator.SetFloat(_runParamName,1.0f);
            _animator.SetBool(_jump,false);
        }
        
    }
}
