using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class waterfpd : MonoBehaviour
{
    public GameObject w;
    bool one = false;
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

        float whb = 0.732f;  //水objの最低位置

        float wfs = 6.263f;   //水objが落ち始める位置

        float ws = 0.14f;     //水objの速さ

        float swl = wha / 43200;
        if ((h == 11) && (m == 59) && (s == 59))
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 1);
            if (!one)
            {
                one = true;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x += 0;
                pos.y = wfs;
                pos.z += 0;
                myTransform.position = pos;
            }

            if (transform.position.y <= whb)
            {
                Transform mTransform = this.transform;
                Vector3 posa = mTransform.position;
                posa.x += 0;
                posa.y = whb;
                posa.z += 0;
                mTransform.position = posa;
            }
            else
            {
                Transform mTransform = this.transform;
                Vector3 posb = mTransform.position;
                posb.x += 0;
                posb.y -= ws;
                posb.z += 0;
                mTransform.position = posb;
            }
        }
        else if (h > 11)
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 1);
            float nwa = sw * swl;
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x += 0;
            pos.y = whb + nwa;
            pos.z += 0;
            myTransform.position = pos;
        }
        else
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 0);
        }
    }
}
