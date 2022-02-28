using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    // 이동속력
    public float speed = 3f;
    //내 자신을 담을 변수
    public GameObject my; 

    private void start()
    {
        //게임 오브젝트에서 Rigidbody컴포넌트를 찾아 playerrigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아
        // playerRigidbody에 할당
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        //수평축에 수직축의 입력값을 감지해서 저장
        float xSpeed = xInput * speed;
        //키보드 : 'A', <- : 음의 방향 : -1.0f
        float zSpeed = zInput * speed;
       
        //vector3속도를 (xspeed, 0f, zspeed) 생성
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //rigidbody의 속도에  newVelocity 할당
        playerRigidbody.velocity = newVelocity;
    }

 
        void DirectInput()
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                playerRigidbody.AddForce(0f, 0f, speed);
            }

            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                playerRigidbody.AddForce(-speed, 0f, 0f);

            }

            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                playerRigidbody.AddForce(speed, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                playerRigidbody.AddForce(0f, 0f, -speed);
            }
        }


    public void Die()
    {
        my.SetActive(false);
        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();

    }
}
