using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        // mp��5�ȏ�̂Ƃ�
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
            
        }
        // mp��5�ȉ��̂Ƃ�
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}


public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 10, 90, 50, 20, 80 };

        Boss lastboss = new Boss();

        // array�̒��g�����Ԃɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // array�̒��g���t���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Magic�֐��� 10 + 1 ��Ăяo��
        for(int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    void Update()
    {
        
    }
}
