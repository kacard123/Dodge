using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
   
    //������ ź���� ���� ������
    public GameObject bulletPrefab;
    //�ּ� �����ֱ�
    public float spawnRateMin = 0.5f;
    //�ִ� �����ֱ�
    public float spawnRateMax = 3f;

    //���� �����ֱ�
    private float spawnRate;
    //�ֱ� ������������ ���� �ð�
    private float timeAfterSpawn;
    //�߻��� ���
    private Transform target;
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        //ź�� ���� ������ spawnRateMin��  spawnRateMax ���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        //PlayerController ������Ʈ�� ���� ����
        //������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� 
        //������
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        //timeAfterSpawn����
        timeAfterSpawn += Time.deltaTime;
        //Ư�� ��ġ ���ϰ��� �ϴ� ��ġ������ ������ �� �ִ�.
        //bulletPrefab�� ��������transform.position
        //��ġ�� transform.rotationȸ������ ����

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //transform�� ������.
            //������ bullet���� ������Ʈ�� ���� ������
            //target�� ���ϵ��� ȸ��
            //void start�� �ѹ� ����ǰ� �������� void update�� �ʴ� 60�� �ݺ��� �ż� ��� �ݺ��ȴ�.
            //void update�� �ҽ��ڵ�� 1�ʿ� 60�� ���ӵǴ� ���� ������ �ּ� ���� �ֱ�� �ִ� ���� �ֱ⸦ �����صξ���.
            //�ð� ���� ��� �����Ͽ� �� �κ��� ���ϴ� �ð��� �߻簡 �ǰԲ� ������ �ǵ��� �Ѵ�. �߻� �ð��� �����ϰ� �����ϸ� 
            //���Ӽ��� �������� �ִ� �ּ� �����ֱ⸦ ������ �������� �����ǰ� �Ѵ�.
            //Time.deltatime
            bullet.transform.LookAt(target);
            //ŸŶ�� �ٶ󺸸鼭 ���ư����� lookat


            //������ ���� ������ spawnRateMin, spawnRateMax ���̿��� ��������
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //������ �ð��� ����
            timeAfterSpawn = 0f;

             }


        //gameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //transform�� ������.
        //������ bullet���� ������Ʈ�� ���� ������
        //target�� ���ϵ��� ȸ��
        //void start�� �ѹ� ����ǰ� �������� void update�� �ʴ� 60�� �ݺ��� �ż� ��� �ݺ��ȴ�.
        //void update�� �ҽ��ڵ�� 1�ʿ� 60�� ���ӵǴ� ���� ������ �ּ� ���� �ֱ�� �ִ� ���� �ֱ⸦ �����صξ���.
        //�ð� ���� ��� �����Ͽ� �� �κ��� ���ϴ� �ð��� �߻簡 �ǰԲ� ������ �ǵ��� �Ѵ�. �߻� �ð��� �����ϰ� �����ϸ� 
        //���Ӽ��� �������� �ִ� �ּ� �����ֱ⸦ ������ �������� �����ǰ� �Ѵ�.
        //Time.deltatime
        //bullet.transform.LookAt(target);


        //������ ����Ǹ� start���� ���۵ȴ�. 


    }
}
