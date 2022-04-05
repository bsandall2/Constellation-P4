using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerToNext : MonoBehaviour
{
    public GameObject fadeObject;
    private Animator anim;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim = fadeObject.GetComponent<Animator>();
            anim.Play("FadeOUT");
        }
    }

}
