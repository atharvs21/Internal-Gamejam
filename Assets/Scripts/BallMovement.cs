using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //Player starting position
    public Vector3 playerTwoPosition;
 public Vector3 playerOnePosition;
 
 //The CharacterControllers
Rigidbody2D playerOne;
 Rigidbody2D playerTwo;
 
 public float speed = 10.0f;
 
 void Start() {
     playerOne = GameObject.FindGameObjectWithTag("Player 1").GetComponent<Rigidbody2D>();
     playerTwo = GameObject.FindGameObjectWithTag("Player 2").GetComponent<Rigidbody2D>();
 }
 
 void Update() {
     if (this.gameObject.tag == "Player 1") {
         if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) {
             playerOnePosition = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
             playerOnePosition = transform.TransformDirection(playerOnePosition);
             playerOnePosition *= speed;
         }
     }
 
     if (this.gameObject.tag == "Player 2") {
         if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow)) {
             playerTwoPosition = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
             playerTwoPosition = transform.TransformDirection(playerTwoPosition);
             playerTwoPosition *= speed;
         }
     }
 
     playerOne.velocity = (playerOnePosition * Time.deltaTime);
     playerTwo.velocity = (playerTwoPosition * Time.deltaTime);
 }  
}