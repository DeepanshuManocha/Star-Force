using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHealth1 : MonoBehaviour
{
    public Image healthBar;
    float maxHealth = 10f;
    public static float enemyhealth_1;
    // Start is called before the first frame update
    void Start()
    {
        //healthBar=GetComponent<Image>();
        enemyhealth_1 = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = enemyhealth_1 / maxHealth;
    }

}
