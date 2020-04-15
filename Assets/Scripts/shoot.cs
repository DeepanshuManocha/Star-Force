using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shoot : MonoBehaviour
{
    // public Button shootbtn;
    //public GameObject music;
    public Camera fpsCam;
    public int damage = 1;
    float range = 10f;
    int count;
    public bool effect;
    public int enemycount = 0;

     public float timeBetweenBullets = 1f; 
    float timer;

    AudioSource gunAudio;                           // Reference to the audio source.
    //ParticleSystem gunParticles;                    // Reference to the particle system.
    //LineRenderer gunLine;
    public GameObject particle;
    //Light gunLight;
float effectsDisplayTime = 0.2f;    

    void start()
    {
        effect=false;
    }
    void Awake ()
    {
        // Create a layer mask for the Shootable layer.
        //shootableMask = LayerMask.GetMask ("Shootable");

        // Set up the references.
       // gunParticles = GetComponent<ParticleSystem> ();
        //gunLine = GetComponent <LineRenderer> ();
        gunAudio = GetComponent<AudioSource> ();
        //gunLight = GetComponent<Light> ();
    }

    void Update()
    {
        timer += Time.deltaTime;
        // shootbtn.onClick.AddListener (onShoot);
        if (Input.GetButtonDown("Fire1")&& timer >= timeBetweenBullets)
        {
            //effect=true;
            onShoot();
            particle.SetActive(true);
            // if(effect==false)
            // {
            //     //effect=true;
            //     particle.SetActive(true);
            //     particle.SetActive(true);
            //     //effect=false;
            // }
            
              
        }
        
        // if(timer >= timeBetweenBullets * effectsDisplayTime)
        //     {
        //         // ... disable the effects.
        //         DisableEffects ();
        //     }
        if(count==30)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    void falseParticeEffect()
    {
        particle.SetActive(false);   
    }
    // void LateUpdate()
    // {
    //     particle.SetActive(false);
    // }
    
    // public void DisableEffects ()
    //     {
    //         // Disable the line renderer and the light.
    //         gunLine.enabled = false;
    //     gunLight.enabled = false;
    //     }

    void onShoot()
    {
        timer = 0f;
        Debug.Log("__________________________________AudioPlayed___________________________");
        gunAudio.Play ();
        InvokeRepeating("falseParticeEffect",2,0);
        //particle.SetActive(true);
        // Enable the light.
        //gunLight.enabled = true;

        // Stop the particles from playing if they were, then start the particles.
        //gunParticles.Stop ();
        //gunParticles.Play ();

        // Enable the line renderer and set it's first position to be the end of the gun.
        //gunLine.enabled = true;
        //gunLine.SetPosition (0, transform.position);
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log("hit");
            EnemiesShreyansh target = hit.transform.GetComponent<EnemiesShreyansh>();
            destroySpwanningStation spwanningTarget = hit.transform.GetComponent<destroySpwanningStation>();
            destroySpwanningStation_1 spwanningTarget_1 = hit.transform.GetComponent<destroySpwanningStation_1>();
            destroySpwanningStation_2 spwanningTarget_2 = hit.transform.GetComponent<destroySpwanningStation_2>();
            if (target != null)
            {
                target.Takedamage(damage);
                enemycount++;
                //music.SetActive(true);

            }
            if (spwanningTarget != null)
            {
                 count++;
                spwanningTarget.Takedamage();
               
            }
            if (spwanningTarget_1 != null)
            {   count++;
                spwanningTarget_1.Takedamage();
                
            }
            if (spwanningTarget_2 != null)
            {    count++;
                spwanningTarget_2.Takedamage();
               
            }

        }
    }
}
