using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDrop : MonoBehaviour
{
    [SerializeField] private float _speedTake = 10; //Скорость Магнита  
    [SerializeField] private float _speedDrop = 20; //Скорость Отталкивания  
    [SerializeField] private float _takeDistance = 10; //Длина луча  
    public RaycastHit _pointRaycast; //Луч который...  
    private bool _takeDrop = false; //Отключили  
    private bool _push = false; //Отключили  
    public Transform _takePosition; //Позиция магнита  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //Условие выполняется пока зажата кнопка клавиатуры  
        {
            Physics.Raycast(transform.position, transform.forward, out _pointRaycast, _takeDistance);
            if (_pointRaycast.rigidbody)
            {
                _takeDrop = true; //Включили  
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_takeDrop)
            {
                _takeDrop = false; //Отключили  
                _push = true; //Включили  
            }
        }
        if (_takeDrop)
        {
            if (_pointRaycast.rigidbody)
            {
                _pointRaycast.rigidbody.freezeRotation = true;
                _pointRaycast.rigidbody.velocity = (_takePosition.position - (_pointRaycast.transform.position + _pointRaycast.rigidbody.centerOfMass)) * _speedTake;
                // Дописать заморозку позиции объекта который взяли

            }
        }
        if (_push)
        {
            if (_pointRaycast.rigidbody)
            {
                _pointRaycast.rigidbody.freezeRotation = false;
                _pointRaycast.rigidbody.velocity = transform.forward * _speedDrop;
                _push = false; //Отключили  
            }
        }
    }
} ﻿ 