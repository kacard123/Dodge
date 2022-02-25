using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigidbody;

    // ź�� �̵� �ӷ�
    public float speed = 8f;

    void Start()
    {
        //���� ������Ʈ���� Rigidbody������Ʈ�� 
        //ã�� BulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�;
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
        
       
     }
    //Ʈ���� �浹�� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浹�� ���� ���� ������Ʈ�� Player �±׸� ��������?
        if (other.tag == "Player")
        {
            //����(�浹��) ���� ������Ʈ����
            //PlayerController ������Ʈ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayController ������Ʈ�� �������� �� �����ߴٸ�
            if (playerController != null)
            {
                //playerController������Ʈ�� Die() �޼��� ����
                playerController.die();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}