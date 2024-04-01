using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 5;

    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "Bullet")
        {
            health -= 1;
            Die();
        }
    }
    
    public void Die()
    {
        if (health == 0)
        {
            Destroy(this.gameObject);
        }
    }
}


