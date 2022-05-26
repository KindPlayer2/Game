using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creditSong : MonoBehaviour
{
    private AudioSource Audio;
    [SerializeField] private AudioClip Credits;
    public static bool scene3 = false;

    private void Start()
    {
        if(scene3 == true)
        {
            Audio = GetComponent<AudioSource>();
            Audio.clip = Credits;
            Audio.PlayOneShot(Credits);
        }
        
    }
}
