using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class secondOr : MonoBehaviour
{
    public GameObject Or;

    float la = -4.603f; //左午前 0
    float ra = -0.459f; //右午前 0
    float lp =  0.459f; //左午後 0
    float rp =  4.603f; //右午後 0
    float oa =  3.850f; //上午前 0
    float ua = -2.370f; //下午前 0
    float op =  3.850f; //上午後 0
    float up = -2.370f; //下午後 0

    float xm = 4.726f - 0.580f; //横幅
    float ym = 3.748f + 2.470f; //縦幅

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;
        int s = now.Second;
        int h = now.Hour;

        float xs = xm / 12; //一秒で動く幅(上横)
        float ys = ym / 18; //一秒で動く幅(縦)

        if ((s % 10 == 0) || (s == 0))
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 1);
        }

        if (!((s % 10 == 0) || (s == 0)))
        {
            SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
            spr.color = new Color(1, 1, 1, 0);
        }

        if (h <= 11)
        {
            float starta = ra - xm / 2;

            if (s == 0)
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = starta;
                poss.y = ua;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if (s <= 6)
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = starta - xs * s;
                poss.y = ua;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 7) && (s <= 24))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = la;
                poss.y = ua + ys * (s - 6);
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 25) && (s <= 36))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = la + xs * (s - 24);
                poss.y = oa;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 37) && (s <= 54))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = ra;
                poss.y = oa - ys * (s - 36);
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 55) && (s <= 59))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = ra - xs * (s - 54);
                poss.y = ua;
                poss.z += 0;
                secTransform.position = poss;
            }
        }
        else
        {
            float startp = rp - xm / 2;

            if (s == 0)
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = startp;
                poss.y = up;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if (s <= 6)
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = startp - xs * s;
                poss.y += 0;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 7) && (s <= 24))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = lp;
                poss.y = up + ys * (s - 6);
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 25) && (s <= 36))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = lp + xs * (s - 24);
                poss.y = op;
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 37) && (s <= 54))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = rp;
                poss.y = op - ys * (s - 36);
                poss.z += 0;
                secTransform.position = poss;
            }
            else if ((s >= 55) && (s <= 59))
            {
                Transform secTransform = this.transform;
                Vector3 poss = secTransform.position;
                poss.x = rp - xs * (s - 54);
                poss.y = up;
                poss.z += 0;
                secTransform.position = poss;
            }
        }
    }
}
