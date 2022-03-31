using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Define : MonoBehaviour
{
    //변수 선언 [접근자] [데이터 타입] 변수명; 

    //변수 선언 시작
    public int a = 10;
    public int b = 2;
    public int c = a+b;
    public int d = a-b;
    //메소드 명이 나오기 직전까지 변수 선언 끝


    // Start is called before the first frame update
    void Start()
    {
        print(c);
        print(d);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
