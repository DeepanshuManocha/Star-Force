using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class damage : MonoBehaviour
{
   // public SakeScreen shake;
    //public int count;
    //public GameObject end;
   // private Animation anim;
   // public GameObject particleEffect;

    

    //public Aibullets damageByBullets;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("inside coliision enter");
        if (collision.gameObject.tag=="bullets")
        {
            //shake.shakeScreen();
            //Instantiate(particleEffect);
            healthbar.health-=1f;
            //Instantiate(blood);
            // Debug.Log("OBject destroyed");
            // SceneManager.LoadScene("EndScene");
        }
        // else if (damageByBullets.hit == true)
        // {
        //     shake.shakeScreen();
        //     count++;
        //     print("count------" + count);
        // }
       // Debug.Log(count);

    }
    public void Update()
    {
        if(healthbar.health==0)
        {
            Debug.Log("OBject destroyed");
         SceneManager.LoadScene("looseScene");
            
            
        }
    }
}
