using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMotion : MonoBehaviour
{

    public Rigidbody2D playerTwo;

    public float speed = 1000.0f;

    public Vector3 playerTwoPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            playerTwoPosition = new Vector3(Input.GetAxis("Horizontal"),  Input.GetAxis("Vertical"),0);
           //    playerTwoPosition = transform.TransformDirection(playerTwoPosition);
           // playerTwoPosition *= speed;
           playerTwoPosition = playerTwoPosition.normalized;
        }
        playerTwo.velocity = (speed*playerTwoPosition * Time.deltaTime);
    }

   
}
