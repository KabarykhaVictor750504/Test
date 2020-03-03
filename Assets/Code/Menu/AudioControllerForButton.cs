using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControllerForButton : MonoBehaviour 
{
    [SerializeField] private AudioSource myFx;
    [SerializeField] private AudioClip clickAudio;
    [SerializeField] private AudioClip enterAudio;
    public void onMouseEnterPlay()
    {
        myFx.PlayOneShot(enterAudio);
    }

    public void onMouseClick()
    {
        myFx.PlayOneShot(clickAudio);
    }

}
