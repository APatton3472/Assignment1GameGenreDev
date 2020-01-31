using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter(Collider rigidbody)
    {
        if (rigidbody.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
