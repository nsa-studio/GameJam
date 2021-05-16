using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerConnect : MonoBehaviour
{
    public float damage;
    public Vector2 direction;

    private void OnTriggerEnter(Collider collider)
    {
        //if (collider.gameObject.tag == "Враг")
        //{
         //   Enemy enemy = collider.gameObject.GetComponent<Enemy>();
         //   enemy.health -= this.damage;
        //}
        //esle
        if (collider.gameObject.tag == "BigBox") // && (Input.GetKey(KeyCode.Alpha1))
        {
            BigBox box = collider.gameObject.GetComponent<BigBox>();
            Vector2 force = this.direction * this.damage;
            box.body.AddForce(force);
            Debug.Log("Большая коробка");
        }
    }
}