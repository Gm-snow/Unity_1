using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muiti_Audio : MonoBehaviour
{
    public AudioClip[] Music = new AudioClip[4]; 
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!AS.isPlaying)
            RandomPlay();
    }

    void Awake()
    {
        AS = this.GetComponent<AudioSource>();
    }

    void RandomPlay()
    {
        AS.clip = Music[Random.Range(0, Music.Length)];
        AS.Play();
    }
}
