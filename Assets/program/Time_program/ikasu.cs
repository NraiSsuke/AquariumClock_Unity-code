using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ikasu : MonoBehaviour
{
    float sp = 0.01f;
    float k = 1.000000000000001f;
    bool one = false;

    // Start is called before the first frame update
    void Start()
    {
        DateTime now = DateTime.Now;
        int h = now.Hour;

        if (h <= 11)
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x = -3.302f;
            pos.y = -2.356f;
            pos.z += 0;
            myTransform.position = pos;
        }
        else
        {
            Transform myTransform = this.transform;
            Vector3 pos = myTransform.position;
            pos.x = 3.302f;
            pos.y = -2.356f;
            pos.z += 0;
            myTransform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DateTime now = DateTime.Now;
        int h = now.Hour;
        int s = now.Second;

        if (!one)
        {
            if (s == 59)
            {
                k = k * 1.0005f;

                sp = sp * k;

                if (h <= 11)
                {
                    if (transform.position.y >= -4.33f)
                    {
                        Transform myTransform = this.transform;
                        Vector3 pos = myTransform.position;
                        pos.x = -3.302f;
                        pos.y -= sp;
                        pos.z += 0;
                        myTransform.position = pos;
                    }
                }
                else
                {
                    if (transform.position.y >= -4.33f)
                    {
                        Transform myTransform = this.transform;
                        Vector3 pos = myTransform.position;
                        pos.x = 3.302f;
                        pos.y -= sp;
                        pos.z += 0;
                        myTransform.position = pos;
                    }
                }
            }
            if(s == 0)
            {
                k = k * 1.03f;

                sp = sp * k;

                if (h <= 11)
                {
                    if (transform.position.y >= -4.33f)
                    {
                        Transform myTransform = this.transform;
                        Vector3 pos = myTransform.position;
                        pos.x = -3.302f;
                        pos.y -= sp;
                        pos.z += 0;
                        myTransform.position = pos;
                    }
                }
                else
                {
                    if (transform.position.y >= -4.33f)
                    {
                        Transform myTransform = this.transform;
                        Vector3 pos = myTransform.position;
                        pos.x = 3.302f;
                        pos.y -= sp;
                        pos.z += 0;
                        myTransform.position = pos;
                    }
                }
            }
            if (s == 1)
            {
                one = true;
            }
        }
        if (s == 10)
        {
            one = false;
            sp = 0.006f;
            k = 1.000000000000001f;

            if (h <= 11)
            {
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = -3.302f;
                pos.y = -2.356f;
                pos.z += 0;
                myTransform.position = pos;
            }
            else
            {
                Transform myTransform = this.transform;
                Vector3 pos = myTransform.position;
                pos.x = 3.302f;
                pos.y = -2.356f;
                pos.z += 0;
                myTransform.position = pos;
            }
        }
    }   
}
