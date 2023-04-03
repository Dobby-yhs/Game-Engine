using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Player;
    public Vector3 pos;

    void Start()
    {
        pos = this.transform.position;
    }

    void Update()
    {
        transform.position = pos + Player.transform.position;
    }
}
