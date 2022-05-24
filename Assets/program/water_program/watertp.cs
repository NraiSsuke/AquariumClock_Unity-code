using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class watertp : MonoBehaviour
{
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
        int s = now.Second;

        int hw = (h - 12) * 3600;
        int mw = m * 60;
        int sw = hw + mw + s;

        float wha = 5.185f;   //水objの動く範囲

        float whb = -4.629f;  //水objの最低位置

        float swl = wha / 43200;

        if (h <= 11)
        {
            float nwa = (sw * swl) + wha;
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += 0;
            pos.y = whb + (wha - nwa);
            pos.z += 0;
            myTransform.position = pos;
        }
        else
        {
            float nwa = sw * swl;
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += 0;
            pos.y = whb + nwa;
            pos.z += 0;
            myTransform.position = pos;
        }
    }
}
