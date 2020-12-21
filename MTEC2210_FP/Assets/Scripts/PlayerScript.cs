using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    
    private AudioSource audioSource;

    public float range = 100f;
    
    private Transform player;

    public float speed;
    
    public float maxBound, minBound;

    // public GameObject PlayerShooter;

    public AudioClip [] soundClips;
    // 0 = Shooting
    // 1 = Explosion

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform> ();

        audioSource = GetComponent<AudioSource>();

    }

   // void FixedUpdate ()
   // { 
     //   if (Input.GetKey(KeyCode.D))
       // {
        //    transform.Translate(10f * Time.deltaTime, 0f, 0f);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(-10f * Time.deltaTime, 0f, 0f);
        //}

    // }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxBound && h > 0)
            h = 0;
        player.position += Vector3.right * h * speed;
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

       // RaycastHit hit;
      // if (Physics.Raycast(PlayerShooter.transform.position, PlayerShooter.transform.forward, out hit))
       // {
         //   Debug.Log(hit.transform.name);
        //}
    }
}
