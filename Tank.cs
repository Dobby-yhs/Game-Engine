using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public int moveSpeed;
    public float move;
    public float moveVertical;

    public int rotSpeed;
    public float rotate;
    public float rotHorizon;

    public float rotTurret;
    public GameObject turret;
    public GameObject gun;

    public int power;   // 포 발사 속도
    public GameObject bulletPrefab; // 총알
    private Transform spPoint;  // 생성 위치치

    public float DestoryTime = 2.0f;   

    void Start()
    {
        moveSpeed = 5;
        rotSpeed = 120;

        power = 1000;
        spPoint = GameObject.Find("spPoint").transform;
    }

    void Update() 
    {
        float keyGun = Input.GetAxis("Mouse ScrollWheel");
        
        Vector3 ang = gun.transform.eulerAngles;
        if (ang.x > 180)
            ang.x -= 360;
        ang.x = Mathf.Clamp(ang.x, -15, 5);
        gun.transform.eulerAngles = ang;

        move = moveSpeed * Time.deltaTime;
        rotate = rotSpeed * Time.deltaTime;

        moveVertical = Input.GetAxis("Vertical");       // 전후진 값
        rotHorizon = Input.GetAxis("Horizontal");       // 회전 값
        rotTurret = Input.GetAxis("Window Shake X");    // 포탑 회전

        transform.Translate(Vector3.forward * move * moveVertical);
        transform.Rotate(new Vector3(0.0f, rotate * rotHorizon, 0.0f));
        turret.transform.Rotate(Vector3.up * rotTurret * rotate);
        gun.transform.Rotate(Vector3.right * keyGun * 4);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, spPoint.position, spPoint.rotation) as GameObject;
            Rigidbody bulletAddforce = bullet.GetComponent<Rigidbody>();
            bulletAddforce.AddForce(turret.transform.forward * power);
            Destroy(bullet, DestoryTime);
        }
    }
}
