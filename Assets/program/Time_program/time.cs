using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class time : MonoBehaviour
{
    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNumber(int num)
    {
        //このゲームオブジェクトの中の SpriteRendererコンポーネントを取得して
        SpriteRenderer spr = this.GetComponent<SpriteRenderer>();
        spr.sprite = sprites[num];
    }
    //変更なし
    //Elementのみ変更
}
