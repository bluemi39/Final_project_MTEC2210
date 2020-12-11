using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    private AudioSource audioSource;

    public float range = 100f;

    public GameObject PlayerShooter;

    public AudioClip [] soundClips;
    // 0 = Shooting
    // 1 = Explosion

    // Start is called before the first frame update
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

    }

    void FixedUpdate ()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(0f, 10f * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -10f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(10f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        }

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {

            FireBullet();

        }

        if (Input.GetKeyDown(KeyCode.E))
        {

            TriggerExplosion();

        }


    }

    void TriggerExplosion()
    {
        audioSource.PlayOneShot(soundClips[1]);

        audioSource.panStereo = 0;

    }

    void FireBullet()
    {
        //Code that fires projectile bullet

        //Play sound
        audioSource.PlayOneShot(soundClips[0]);

        RaycastHit hit;
       if (Physics.Raycast(PlayerShooter.transform.position, PlayerShooter.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
