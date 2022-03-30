using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstscript : MonoBehaviour
{
    //객체가 생성되기 시작할 때 실행되는 함수
    void Awake()
    {
        print("Set Anmiry for the enemy");

    }
    //객체 생성후 실행/객체가 보이자마자 실행 
    void Start()
    {
        print("Allow enemy to shoot");
        
    }

    // 메시간마다 반복. 화면을 갱신해주는 함수
    void Update()
    {
        print("Shoot");
    }
    //특정 시간에 물리적인 반응을 갱신. 특정 물체가 움직이거나, 부딪칠 때 갱신
    void FixedUpdate()
    {
        print("Fire");

    }
}
