using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
   
    //생성할 탄알의 원본 프리팹
    public GameObject bulletPrefab;
    //최소 생성주기
    public float spawnRateMin = 0.5f;
    //최대 생성주기
    public float spawnRateMax = 3f;

    //실제 생성주기
    private float spawnRate;
    //최근 생성시점에서 지난 시간
    private float timeAfterSpawn;
    //발사할 대상
    private Transform target;
    void Start()
    {
        //최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        //탄알 생성 간격을 spawnRateMin과  spawnRateMax 사이에서 랜덤 값 지정
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);

        //PlayerController 컴포넌트를 가진 게임
        //오브젝트를 찾아서 그 오브젝트의 위치값을 
        //가져와
        target = FindObjectOfType<PlayerController>().transform;
    }

    
    void Update()
    {
        //timeAfterSpawn갱신
        timeAfterSpawn += Time.deltaTime;
        //특정 위치 원하고자 하는 위치에서도 지정할 수 있다.
        //bulletPrefab의 복제본을transform.position
        //위치와 transform.rotation회전으로 생성

        //최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (timeAfterSpawn >= spawnRate)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            //transform은 변수다.
            //생성된 bullet게임 오브젝트의 정면 방향이
            //target을 향하도록 회전
            //void start는 한번 실행되고 끝이지만 void update는 초당 60번 반복이 돼서 계속 반복된다.
            //void update는 소스코드는 1초에 60번 지속되는 것을 막으려 최소 생성 주기와 최대 생성 주기를 설정해두었다.
            //시간 값을 계속 측정하여 그 부분을 원하는 시간에 발사가 되게끔 실행이 되도록 한다. 발사 시간을 일정하게 설정하면 
            //게임성이 떨어지니 최대 최소 생성주기를 설정해 랜덤으로 설정되게 한다.
            //Time.deltatime
            bullet.transform.LookAt(target);
            //타킷을 바라보면서 날아가도록 lookat


            //다음번 생성 간격을 spawnRateMin, spawnRateMax 사이에서 랜덤지정
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //누적된 시간을 리셋
            timeAfterSpawn = 0f;

             }


        //gameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        //transform은 변수다.
        //생성된 bullet게임 오브젝트의 정면 방향이
        //target을 향하도록 회전
        //void start는 한번 실행되고 끝이지만 void update는 초당 60번 반복이 돼서 계속 반복된다.
        //void update는 소스코드는 1초에 60번 지속되는 것을 막으려 최소 생성 주기와 최대 생성 주기를 설정해두었다.
        //시간 값을 계속 측정하여 그 부분을 원하는 시간에 발사가 되게끔 실행이 되도록 한다. 발사 시간을 일정하게 설정하면 
        //게임성이 떨어지니 최대 최소 생성주기를 설정해 랜덤으로 설정되게 한다.
        //Time.deltatime
        //bullet.transform.LookAt(target);


        //게임이 실행되면 start부터 시작된다. 


    }
}
