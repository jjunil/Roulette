using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RouletteController : MonoBehaviour
{


    // Start is called before the first frame update
    public float rotSpeed = 0; //회전 속도



    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //클릭하면 회전 속도를 설정한다.
        if (Input.GetMouseButtonDown(2))
        {
            this.rotSpeed = 10;
        }

        //회전 속도만큼 룰렛을 회전시킨다.

        transform.Rotate(0,0,this.rotSpeed);

        //룰렛을 감속시킨다.
        this.rotSpeed *= 0.994f;

        if (rotSpeed < 0.1f) //룰렛이 멈출 때
        {
            if
        }
    }
}
