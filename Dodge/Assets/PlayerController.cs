using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵��ӷ�
    public float speed = 3f;

    public GameObject my; 

    private void start()
    {
        //���� ������Ʈ���� Rigidbody������Ʈ�� ã�� playerrigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        // Ű���� : 'A' < - : ���� ���� : �ִ� -1.0f
        //Ű���� : 'D' -> : ���� ���� :  +1.0f
        float zInput = Input.GetAxis("Vertical");
        //Ű���� : 'W',^ : ���ǹ��� : +1.0f
        //Ű���� : 'S', �� : ���ǹ��� : -1.0f
    
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
