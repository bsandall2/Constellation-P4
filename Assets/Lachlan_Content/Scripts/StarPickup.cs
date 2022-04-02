using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
public int value = 1;
public GameObject pickupEffect;
public AudioClip starSound;

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AddStars(value);
            Instantiate(pickupEffect, transform.position, transform.rotation);
            AudioSource.PlayClipAtPoint(starSound, transform.position);
            

            Destroy(pickupEffect);
            Destroy(gameObject);
        }
    }
}
