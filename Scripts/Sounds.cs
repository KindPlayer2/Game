using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private AudioSource Audio;
    [SerializeField] private AudioClip Background;
    public static bool scene2 = false;

    private void Start()
    {
        if(scene2 == true)
        {
            Audio = GetComponent<AudioSource>();
            Audio.clip = Background;
            Audio.loop = true;
            Audio.playOnAwake = true;
            Audio.Play(0);
        }
        
    }
}
