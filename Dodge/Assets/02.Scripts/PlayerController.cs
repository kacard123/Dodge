using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵��ӷ�
    public float speed = 3f;
    //�� �ڽ��� ���� ����
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
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // playerRigidbody�� �Ҵ�
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        //�����࿡ �������� �Է°��� �����ؼ� ����
        float xSpeed = xInput * speed;
        //Ű���� : 'A', <- : ���� ���� : -1.0f
        float zSpeed = zInput * speed;
       
        //vector3�ӵ��� (xspeed, 0f, zspeed) ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //rigidbody�� �ӵ���  newVelocity �Ҵ�
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
        //���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();

        gameManager.EndGame();

    }
}
