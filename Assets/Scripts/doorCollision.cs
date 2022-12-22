using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorCollision : MonoBehaviour
{ int count = 0;
    // Start is called before the first frame update

    public BombCount b1;
    public BombCount b2;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player 1" && b1.BombCountID > 0 )
        {
           
            b1.BombCountID -= 1;

            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Player 2" && b2.BombCountID > 0)
        {
           
            b2.BombCountID -= 1;
            Destroy(gameObject);
        }
    }
}
