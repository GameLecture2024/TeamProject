// using -  : 네임스페이스 :  부산 - 김민수 서울 - 김민수
// public class 이름   : 클래스
// void Start( ){ }    : 함수, 메소드
// 명령문 statement : 코드 ; 이루어져 있는 구성요소

using UnityEngine;   // 다른 네임 스페이스에 만들어진 똑같은 이름의 클래스가 있다면 컴퓨터가 구별을 할 수 없다.
using System;

// ctlr + K ctrl + S

public class MouseWorld : MonoBehaviour
{
    private void Update() // 프레임 마다 실행이 됩니다. 이미지가 그려지는 시간을 프레임. 계속해서 실행한다.
    {
        // 마우스의 위치를 World 세상으로 바꾸고 싶습니다.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // 컴퓨터에게 명령문 
        Physics.Raycast(ray, out RaycastHit hit);                    // 명령문2 : 광선으로 부터 충돌한 지점을 가져온다. hit
        Debug.Log(hit.point);                                        // 명령문3

        transform.position = hit.point;
    }
} 

