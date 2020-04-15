using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpwanningStation : MonoBehaviour
{
    public float health = 10f;
    public GameObject explosion;
    public GameObject explosion2;
  
    public void Takedamage()
    {
        health -= 1f;
        enemyHealth.enemyhealth = health;

        // damage-=1f;
        //enemyHealth.health=damage;
        //damage=enemyHealth.health;
        //damage-=1f;
        if (enemyHealth.enemyhealth == 0)
        {
            int a = Random.Range(0, 1);
            if (a == 0)
            {
                explosion.SetActive(true);

            }
            if (a == 1)
            {
                explosion2.SetActive(true);
            }
            InvokeRepeating("die", 2, 0);
        }
    }

    void die()
    {
        Destroy(gameObject);
        Debug.Log("destroy");
    }

}
