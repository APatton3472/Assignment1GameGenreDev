using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;  
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(2);
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Die();
        } 
    }

    void OnCollisionEnter(Collision rigidbody)
    {
        if (rigidbody.gameObject.tag == "Enemy")
        {
            currentHealth = currentHealth - 1;
        }
        if (rigidbody.gameObject.tag == "Finish")
        {
            Application.LoadLevel(3);
        }
    }

        void Die()
    {
        Application.LoadLevel(2);
    }
}
