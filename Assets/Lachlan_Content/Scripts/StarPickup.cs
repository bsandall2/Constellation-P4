using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
public int value = 1;
public GameObject pickupEffect;

public GameObject objectToMove;
public Vector3 moveDirection;

// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().AddStars(value);
            Destroy(gameObject);
            
            StartCoroutine(LerpPosition(moveDirection, 1));
            //objectToMove.transform.position = Vector3.Lerp(transform.position, moveDirection, 10.0f);

            //Instantiate(pickupEffect, transform.position, transform.rotation);

            //Destroy(gameObject);
        }
    }
}
