using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombCount : MonoBehaviour
{   public int BombCountID = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.tag == "BOMB")

        {
            BombCountID= BombCountID + 1;
            Destroy(collision.gameObject);
        }

        
    }
}
