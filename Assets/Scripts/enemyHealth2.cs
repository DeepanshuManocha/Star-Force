using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth2 : MonoBehaviour
{
    public Image healthBar;
    float maxHealth = 10f;
    public static float enemyhealth_2;
    // Start is called before the first frame update
    void Start()
    {
        //healthBar=GetComponent<Image>();
        enemyhealth_2 = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = enemyhealth_2 / maxHealth;
    }

}
