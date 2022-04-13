using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public GameObject myLight; //directional Light 게임 객제가 저장
    Light myLight_LightComponent; //Direstional light 게임 객체의 Light 컴포넌트가 저장되어 있음
    Transform myLight_TransformComponent;

    public GameObject myCube;

    public GameObject prefabCube; //프리팹 파일을 저장하기 위한 객체
    GameObject newCube; //프리팹 객체를 이용해 만든 객체

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
            //만약 p키가 눌리면 light 컴포넌트를 비활성화 시킨다
            myLight_LightComponent.enabled = false;
            //myCude객체를 비활성화 시키기 위해서 메소드를 사용해야 함
            myCube.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            //만약 o키가 눌리면 light 컴포넌트를 활성화 시킨다.
            //myCude객체를 활성화 시킨다.
            myLight_LightComponent.enabled = true;
            myCube.SetActive(true);
        }

        //만약 m키를 누르면
        if (Input.GetKeyDown(KeyCode.M))
        {
            Destroy(myCube); //myCube를 메모리에서 삭제한다
        }
        //만약 n키를 누르면

        if (Input.GetKeyDown(KeyCode.N))
        {
            //프리팹으로 만든 Cube를 생성한다.
            //위치 Vector3(0,0,0) --> Vector3.zero
            //회전 Vector3(0,0,0) --> Quaternion.identity
            newCube = Instantiate(prefabCube, Vector2.zero, Quaternion.identity);
        }


    }
}
