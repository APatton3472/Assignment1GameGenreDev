﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int enemyalive = 1;
        if (enemyalive == 1)
        {
            this.transform.position = new Vector3(this.transform.position.x +(speed * Time.deltaTime),this.transform.position.y, this.transform.position.z);
            this.transform.position = new Vector3(this.transform.position.x -(speed * Time.deltaTime), this.transform.position.y, this.transform.position.z);
        }
        
    }
}
