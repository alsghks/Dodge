using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody platerRigidbody; // 이동에 사용할 리지드바디 컴포넌트
    public float speed = 8f; //이동 속력
    //Use this for initialzation
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //위쪽 방향키 입력이 감지된경우 z방향 힘주기
            platerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //아래쪽 방향키 입력이 감지된 경우 -z방향 힘주기
            platerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //오른쪽 방향키 입력이 감지된 경우 x 방향 힘주기
            platerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //왼쪽 방향키 입력이 감지된 경우 -x 방향 힘주기
            platerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }
    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);      
    }
}
