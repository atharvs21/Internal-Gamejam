using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
   public float timer;
    public int Tc;
    public Text text;
    public GameObject g1;
    public GameObject g2;
    //public LeftMotion l1;
    void Start()
    {
        timer = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        Tc = (int)timer;
        text.text = Tc.ToString();
        if (timer <= 0)

        {

            text.text = " ";
            g1.GetComponent<LeftMotion>().enabled = true;
            g2.GetComponent<RightMotion>().enabled = true;
        }

    }
}
