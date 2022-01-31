using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        // mpが5以上のとき
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            
        }
        // mpが5以下のとき
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}


public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 10, 90, 50, 20, 80 };

        Boss lastboss = new Boss();

        // arrayの中身を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // arrayの中身を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Magic関数を 10 + 1 回呼び出す
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    void Update()
    {
        
    }
}
