using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class bubbleA : MonoBehaviour
{
    float ax = -1.91f;         //午前の泡のx座標
    float px = 2.22f;          //午後の泡のx座標
    float wha = 5.185f;        //水objの動く範囲    
    float whb = -2.08f;        //水objの最低位置 

    //    ↓動く速さ

    float ya = 0.02f;         //上げると早く、下げると遅くなる
    float yar = 0.02f;

    float movya = 0.965f;
    float movyar = 0.965f;

    float yb = 0.01f;         //上げると早く、下げると遅くなる
    float ybr = 0.01f;

    float movyb = 1.05f;
    float movybr = 1.05f;

    float movva = 0.05f;  //沈むときの減速度

    float movvb = 0.00000015f;    //浮かぶときの加速度

    //動かす幅、位置
    
    float sen = 0.175f;          //沈ませる幅

    float t = 0.05f;            //沈むまでに動かす横幅

    float movxx = 0.0025f;     //沈むときに動かす横幅

    float movxxx = 0.00001f;     //浮かぶときに動かす横幅
    
    void Start()
    {

    }

    void Update()
    {
        float ran = UnityEngine.Random.Range(0, 1.0f);
        if (ran > 0.006) //泡が出現する条件
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 1);
            bubblemov();
        }
        else
        {
            DateTime now = DateTime.Now;
            int h = now.Hour;
            int m = now.Minute;
            int s = now.Second;

            if (h <= 11)  //午前の場合                                                
            {
                int hw = h * 3600;
                int mw = m * 60;
                int sw = hw + mw + s;
                float swl = wha / 43200;
                float nwa = sw * swl;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = ax;
                pos.y = whb + nwa;
                pos.z += 0;
                myTransform.position = pos;
                ya = yar;
                movya = movyar;
                yb = ybr;
                movyb = movybr;//
            }
            else            //午後の場合                                              
            {
                int hw = (h - 12) * 3600;
                int mw = m * 60;
                int sw = hw + mw + s;
                float swl = wha / 43200;
                float nwa = sw * swl;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = px;
                pos.y = whb + nwa;
                pos.z += 0;
                myTransform.position = pos;
                ya = yar;
                movya = movyar;
                yb = ybr;
                movyb = movybr;
            }
        }
    }

    void bubblemov()
    {
        DateTime nowb = DateTime.Now;
        int hb = nowb.Hour;
        int mb = nowb.Minute;
        int sb = nowb.Second;

        if (hb <= 11)
        {
            int hwb = hb * 3600;
            int mwb = mb * 60;
            int swb = hwb + mwb + sb;
            float swlb = wha / 43200;
            float nwab = swb * swlb;
            float l = whb + nwab;
            bubblea(l);
        }
        else
        {
            int hwb = (hb - 12) * 3600;
            int mwb = mb * 60;
            int swb = hwb + mwb + sb;
            float swlb = wha / 43200;
            float nwab = swb * swlb;
            float l = whb + nwab;
            bubblea(l);
        }
    }

    void bubblea(float l)
    {
        DateTime nowc = DateTime.Now;
        int hc = nowc.Hour;
        int sc = nowc.Second;
        int mc = nowc.Minute;

        if (hc <= 11)                  //午前の時                                     
        {
            float jh = ax - t;
            if ((transform.position.y > l - sen) && (transform.position.x > jh))
            {
                ya = ya * movya;
                movya = movya - movva;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x -= movxx;
                pos.y -= ya;
                pos.z += 0;
                myTransform.position = pos;
            }
            if (transform.position.y < whb)
            {
                int hw = hc * 3600;
                int mw = mc * 60;
                int sw = hw + mw + sc;
                float swl = wha / 43200;
                float nwa = sw * swl;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = ax;
                pos.y = whb + nwa;
                pos.z += 0;
                myTransform.position = pos;
                ya = yar;
                movya = movyar;
                yb = ybr;
                movyb = movybr;
            }
            if ((transform.position.x <= jh) && (transform.position.y <= l))
            {
                yb = yb * movyb;
                movyb = movyb + movvb;
                Transform mTransform = this.transform;
                Vector3 posa = mTransform.position;
                posa.x -= movxxx;
                posa.y += yb;
                posa.z += 0;
                mTransform.position = posa;
            }
            if (transform.position.y >= l - 0.0005)
            {
                SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
                spr.color = new Color(1, 1, 1, 0);
                Transform mybTransform = this.transform;
                Vector3 posb = mybTransform.position;
                posb.x += 0;
                posb.y += 0;
                posb.z += 0;
                mybTransform.position = posb;
            }
        }
        else                            //午後の時                                   
        {
            float jh = px - t;
            if ((transform.position.y > l - sen) && (transform.position.x > jh))
            {
                ya = ya * movya;
                movya = movya - movva;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x -= movxx;
                pos.y -= ya;
                pos.z += 0;
                myTransform.position = pos;
            }
            if (transform.position.y < whb)
            {
                int hw = (hc - 12) * 3600;
                int mw = mc * 60;
                int sw = hw + mw + sc;
                float swl = wha / 43200;
                float nwa = sw * swl;
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = px;
                pos.y = whb + nwa;
                pos.z += 0;
                myTransform.position = pos;
                ya = yar;
                movya = movyar;
                yb = ybr;
                movyb = movybr;
            }
            if ((transform.position.x <= jh) && (transform.position.y <= l))
            {
                yb = yb * movyb;
                movyb = movyb + movvb;
                Transform mTransform = this.transform;
                Vector3 posa = mTransform.position;
                posa.x -= movxxx;
                posa.y += yb;
                posa.z += 0;
                mTransform.position = posa;

            }
            if (transform.position.y >= l - 0.0005)
            {
                SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
                spr.color = new Color(1, 1, 1, 0);
                Transform mybTransform = this.transform;
                Vector3 posb = mybTransform.position;
                posb.x += 0;
                posb.y += 0;
                posb.z += 0;
                mybTransform.position = posb;
            }
            if (transform.position.y < whb)
            {
                Transform mybTransform = this.transform;
                Vector3 posb = mybTransform.position;
                posb.x -= movxx;
                posb.y += 0;
                posb.z += 0;
                mybTransform.position = posb;
            }
        }
    }
}
