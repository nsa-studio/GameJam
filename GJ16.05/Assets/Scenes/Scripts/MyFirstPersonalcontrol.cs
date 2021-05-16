using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class MyFirstPersonalcontrol : MonoBehaviour
{
   	[SerializeField] private float _moveSpeedMultiplayer = 5f;
    [SerializeField, Range(0.0f, 1.0f)] private float _percentToSlowStop = 0.01f;
    
   public float PercentToSlowStop => (1 - _moveSpeedMultiplayer);
    
   private Rigidbody _body;
   private Vector3 _moveDirection;
   private bool _isMooved = false;
	bool is_ground = false;     //переменная которая хранит в себе значение, "на земле ли игрок"
	
	public float force = 6;     //сила с которой будет прыгать персонаж

	void Start()
   {
      _body = GetComponent<Rigidbody>();
		
		PlayerController.OnInput += Move;

   }

   private void Move(Vector3 input)
   {
	   _moveDirection.Set(input.x, 0, input.z);
      
	   //Двигаемся
	   _body.AddForce(_moveDirection * _moveSpeedMultiplayer);
	   _isMooved = true;
	   
   }
   
	private void Update()
   {
	   //Смотрим по направлению движения
	   transform.LookAt(_moveDirection + transform.position);
	   
	   
		var horizontal = Input.GetAxis("Horizontal");
   		var vertical = Input.GetAxis("Vertical");
		if (Input.GetKeyDown(KeyCode.Space) && is_ground)               //если нажата кнопка "пробел" и игрок на земле
		{
			Debug.Log("Прыжок");
			_body.AddForce(Vector3.up * force, ForceMode.Impulse);   //то придаем ему силу вверх импульсным пинком
		}

	}

	private void FixedUpdate()
	{
		if (_isMooved) return;
		
			_body.velocity = new Vector3(_body.velocity.x * PercentToSlowStop,
			_body.velocity.y,
			_body.velocity.z * PercentToSlowStop);
	}

	private void LateUpdate()
	{
		if (_moveDirection == Vector3.zero)
		{
			_isMooved = false;
		}
	}
	void OnTriggerStay(Collider col)
	{               //если в тригере что то есть и у обьекта тег "ground"
		if (col.tag == "ground")
		{
			Debug.Log("Земля");
			is_ground = true;
		}
		//то включаем переменную "на земле"
	}
	void OnTriggerExit(Collider col)
	{              //если из триггера что то вышло и у обьекта тег "ground"
		if (col.tag == "ground")
		{
			Debug.Log("Воздух");
			is_ground = false;
		}
		//то вЫключаем переменную "на земле"
	}
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.name.Equals("Platform"))
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

