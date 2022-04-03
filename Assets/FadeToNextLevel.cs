using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToNextLevel : MonoBehaviour
{
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(1);
    }
}
