using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeController : MonoBehaviour
{
    public GameObject mi1;
    public GameObject mi10;
    public GameObject ho1;
    public GameObject ho10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;
        int h = now.Hour;
        int m = now.Minute;

        if(h > 11)
        {
            int hp = h - 12;
            int h1 = hp % 10;
            int h10 = hp / 10;
            ho1.GetComponent<time>().setNumber(h1);
            ho10.GetComponent<time>().setNumber(h10);
        }
        else
        {
            int hp = h;
            int h1 = hp % 10;
            int h10 = hp / 10;
            ho1.GetComponent<time>().setNumber(h1);
            ho10.GetComponent<time>().setNumber(h10);
        }
        
        int m1 = m % 10;
        int m10 = m / 10;
        

        mi1.GetComponent<time>().setNumber(m1);
        mi10.GetComponent<time>().setNumber(m10);
        
    }
    //変更なし
}