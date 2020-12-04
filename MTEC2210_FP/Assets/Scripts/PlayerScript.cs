using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float ForwardForce = 10f;

    public Transform rb;

    private AudioSource audioSource;

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
        

        if (Input.GetKey("w"))
        {
            rb.AddForce(ForwardForce * Time.deltaTime, 0, 0);
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
    }
}
