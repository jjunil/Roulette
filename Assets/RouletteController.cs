using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RouletteController : MonoBehaviour
{


    // Start is called before the first frame update
    public float rotSpeed = 0; //ȸ�� �ӵ�



    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //Ŭ���ϸ� ȸ�� �ӵ��� �����Ѵ�.
        if (Input.GetMouseButtonDown(2))
        {
            this.rotSpeed = 10;
        }

        //ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.

        transform.Rotate(0,0,this.rotSpeed);

        //�귿�� ���ӽ�Ų��.
        this.rotSpeed *= 0.994f;

        if (rotSpeed < 0.1f) //�귿�� ���� ��
        {
            if
        }
    }
}
