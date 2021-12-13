using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{


    [SerializeField] int health;
    [SerializeField] HealthBarScript healthBar;



    void Start()
    {
        healthBar.SetMaxHealth(health);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
    }

}
