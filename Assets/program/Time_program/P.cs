using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class P : MonoBehaviour
{
    public GameObject PM;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime d = DateTime.Now;
        int h = d.Hour;

        if(h < 12)
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 0);
        }
        if(h > 11)
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 1);
        }
    }
    //変更なし
}
