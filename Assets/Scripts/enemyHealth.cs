using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public Image healthBar;
    float maxHealth = 10f;
    public static float enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
        //healthBar=GetComponent<Image>();
        enemyhealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = enemyhealth / maxHealth;
    }

}
