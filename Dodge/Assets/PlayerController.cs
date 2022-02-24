using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    // 이동속력
    public float speed = 3f;

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
        float xInput = Input.GetAxis("Horizontal");
        // 키보드 : 'A' < - : 음의 방향 : 최대 -1.0f
        //키보드 : 'D' -> : 양의 방향 :  +1.0f
        float zInput = Input.GetAxis("Vertical");
        //키보드 : 'W',^ : 양의방향 : +1.0f
        //키보드 : 'S', ▼ : 음의방향 : -1.0f
    
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
   
   
    void Die()
    {
        my.SetActive(false);
        
    }
}
