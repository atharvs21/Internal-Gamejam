using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    // Start is called before the first frame update
   public Vector2[] pos;
    public GameObject bomb;
    void Start()
    {
        int s1 = Random.Range(0, 3);
        Instantiate(bomb, new Vector3(pos[s1].x,  pos[s1].y,0),Quaternion.identity);
        Instantiate(bomb, new Vector3(-pos[s1].x, pos[s1].y,0), Quaternion.identity);
        int s2 = Random.Range(4, 7);
        Instantiate(bomb, new Vector3(pos[s2].x,  pos[s2].y,0), Quaternion.identity);
        Instantiate(bomb, new Vector3(-pos[s2].x,  pos[s2].y,0), Quaternion.identity);
        int s3 = Random.Range(8, 11);
        Instantiate(bomb, new Vector3(pos[s3].x,  pos[s3].y,0), Quaternion.identity);
        Instantiate(bomb, new Vector3(-pos[s3].x, pos[s3].y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    
}
