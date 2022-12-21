using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMotion : MonoBehaviour
{ public Rigidbody2D playerOne;

    public float speed = 10000.0f;

    public Vector3 playerOnePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
        {
            playerOnePosition = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
           // playerOnePosition = transform.TransformDirection(playerOnePosition);
            //playerOnePosition *= speed;
            playerOnePosition= playerOnePosition.normalized;
        }

        playerOne.velocity = (speed*playerOnePosition * Time.deltaTime);
    }
}
