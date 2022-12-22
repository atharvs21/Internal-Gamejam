using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("true");
        if(collision.gameObject.tag == "Player 1")
        {
            SceneManager.LoadScene("Player1 Win");
        }

        if(collision.gameObject.tag == "Player 2")
        {
            SceneManager.LoadScene("Player2 Win");
        }
    }
}
