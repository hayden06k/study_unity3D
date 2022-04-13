using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public GameObject myTop;
    
    public float moveSpeed;
    public float rotSpeed;
    public float topRotSpeed;

    public GameObject bullet;
    public Transform spwanPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float v = Input.GetAxis("Vertical");//위쪽 화살를 누르면 1, 아래쪽 화살키를 누르면 -1
        this.transform.Translate(Vector3.forward * v*Time.deltaTime * moveSpeed); //이 값을 이용해서 앞 뒤로 이동하게 하고싶다                                  //이 값을 이용해서 앞 뒤로 이동하게 하고 싶다.


        float h = Input.GetAxis("Horizontal");//왼족 화살키와 오른쪽 화살키를 누르면 -1~1
        this.transform.Rotate(Vector3.up * h, 15.0f * Time.deltaTime* rotSpeed);//탱크를 회전 시키고 싶다.

        //q키를 누르면 -1, e키를 누르면 1을 얻은 후
        //그 값을 이용해서 top을 회전

        float m = Input.GetAxis("myTop");
        myTop.transform.Rotate(Vector3.up * m, 15.0f * Time.deltaTime* topRotSpeed);

        //왼쪽 ctrl --> fire1 키를 누르면
        //bullet을 이용해서 spwanPoint -> position에 Quatanian.identity 회전시켜 객체를 만듬
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, spwanPoint.position, Quaternion.identity);
        }
    
    }
}
