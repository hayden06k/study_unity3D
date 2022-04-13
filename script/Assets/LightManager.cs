using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public GameObject myLight; //directional Light ���� ������ ����
    Light myLight_LightComponent; //Direstional light ���� ��ü�� Light ������Ʈ�� ����Ǿ� ����
    Transform myLight_TransformComponent;

    public GameObject myCube;

    public GameObject prefabCube; //������ ������ �����ϱ� ���� ��ü
    GameObject newCube; //������ ��ü�� �̿��� ���� ��ü

    // Start is called before the first frame update
    void Start()
    {
        myLight_LightComponent = myLight.GetComponent<Light>();
        myLight_TransformComponent = myLight.GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //���� pŰ�� ������ light ������Ʈ�� ��Ȱ��ȭ ��Ų��
            myLight_LightComponent.enabled = false;
            //myCude��ü�� ��Ȱ��ȭ ��Ű�� ���ؼ� �޼ҵ带 ����ؾ� ��
            myCube.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            //���� oŰ�� ������ light ������Ʈ�� Ȱ��ȭ ��Ų��.
            //myCude��ü�� Ȱ��ȭ ��Ų��.
            myLight_LightComponent.enabled = true;
            myCube.SetActive(true);
        }

        //���� mŰ�� ������
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(myCube); //myCube�� �޸𸮿��� �����Ѵ�
        }
        //���� nŰ�� ������

        if (Input.GetKeyDown(KeyCode.N))
        {
            //���������� ���� Cube�� �����Ѵ�.
            //��ġ Vector3(0,0,0) --> Vector3.zero
            //ȸ�� Vector3(0,0,0) --> Quaternion.identity
            newCube = Instantiate(prefabCube, Vector2.zero, Quaternion.identity);
        }


    }
}
