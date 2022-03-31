using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifmoon : MonoBehaviour
{
    public bool a,b,c,d;
    // Start is called before the first frame update
    void Start(){
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            print("플레이어가 스페이스바를 눌렀습니다");
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            print("왼쪽 방향키 클릭");
        }else if(Input.GetKeyDown(KeyCode.RightArrow)){
            print("오른쪽 방향키 클릭");
        }else if(Input.GetKeyDown(KeyCode.UpArrow)){
             print("아래쪽 방향키 클릭");
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
            print("위쪽 방향키 클릭");
        }
        
    }
}
