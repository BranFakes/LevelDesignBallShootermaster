using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  

public class JumpPadController : MonoBehaviour
{
 public GameObject player;
    Vector3 direction;
    public float jumpForce = 5f;


  
    void Update()
    {
        direction = transform.TransformDirection(Vector3.up * jumpForce);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            player = collision.gameObject;
            
            player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        }
    }
}
