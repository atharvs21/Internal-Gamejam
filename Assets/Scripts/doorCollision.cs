using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorCollision : MonoBehaviour
{ int count = 0;
    // Start is called before the first frame update
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player 1" )
        {
            Debug.Log("true");

            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player 2" && count != 0)
        {
            Debug.Log("true");
            Destroy(gameObject);
        }
    }
}
