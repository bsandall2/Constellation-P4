using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject fadeBackground;
    private Animator anim;

    void Start()
    {
        anim = fadeBackground.GetComponent<Animator>();
    }

    public void PlayGame()
    {       
        anim.Play("FadeOUT");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
   
}
