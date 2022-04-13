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

        float v = Input.GetAxis("Vertical");//���� ȭ�츦 ������ 1, �Ʒ��� ȭ��Ű�� ������ -1
        this.transform.Translate(Vector3.forward * v*Time.deltaTime * moveSpeed); //�� ���� �̿��ؼ� �� �ڷ� �̵��ϰ� �ϰ�ʹ�                                  //�� ���� �̿��ؼ� �� �ڷ� �̵��ϰ� �ϰ� �ʹ�.


        float h = Input.GetAxis("Horizontal");//���� ȭ��Ű�� ������ ȭ��Ű�� ������ -1~1
        this.transform.Rotate(Vector3.up * h, 15.0f * Time.deltaTime* rotSpeed);//��ũ�� ȸ�� ��Ű�� �ʹ�.

        //qŰ�� ������ -1, eŰ�� ������ 1�� ���� ��
        //�� ���� �̿��ؼ� top�� ȸ��

        float m = Input.GetAxis("myTop");
        myTop.transform.Rotate(Vector3.up * m, 15.0f * Time.deltaTime* topRotSpeed);

        //���� ctrl --> fire1 Ű�� ������
        //bullet�� �̿��ؼ� spwanPoint -> position�� Quatanian.identity ȸ������ ��ü�� ����
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, spwanPoint.position, Quaternion.identity);
        }
    
    }
}
