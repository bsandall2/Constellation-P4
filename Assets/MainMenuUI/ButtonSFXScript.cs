using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSFXScript : MonoBehaviour
{
    public AudioSource myfx;
    public AudioClip hoverFX;
    public AudioClip clickFX;

    public void HoverSound()
    {
        myfx.PlayOneShot(hoverFX);
    }

    public void ClickSound()
    {
        myfx.PlayOneShot(clickFX);
    }
}
