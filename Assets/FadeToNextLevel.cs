using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToNextLevel : MonoBehaviour
{
    public int loadNumber;

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(loadNumber);
    }
}
