using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    [SerializeField] private int speed = 5; //Скорость персонажа
    [SerializeField] private GameObject player; //здесь указываем персонажа;
    
    
   

    void Start()
    {
        player = (GameObject)gameObject; //тут присваиваем персонажа к игровому Object
       
    }

    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
        }


    }
}
  

