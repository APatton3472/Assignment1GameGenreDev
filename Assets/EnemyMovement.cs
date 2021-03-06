﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //found at https://forum.unity.com/threads/moving-an-object-back-and-forth-on-a-single-axis-automatically.235033/
    public float min = 2f;
    public float max = 3f;

    // Use this for initialization
    void Start()
    {
        min = transform.position.x - min;
        max = transform.position.x + max;
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);

    }
    
}