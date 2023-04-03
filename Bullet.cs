using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int power = 1000;       // 포 발사 속도
    public AudioClip bulletsound;
    public GameObject exp;

    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * power);
    }

    void OnTriggerEnter(Collider col)
    {
        AudioSource.PlayClipAtPoint(bulletsound, transform.position);
        GameObject copy_exp = Instantiate(exp) as GameObject;

        if (col.gameObject.tag == "Wall")
        {
            copy_exp.transform.position = col.transform.position;
            Destroy(col.gameObject);
        }
        copy_exp.transform.position = transform.position;
        Destroy(gameObject);
    }
}
