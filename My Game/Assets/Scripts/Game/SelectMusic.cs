using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMusic : MonoBehaviour
{
    [SerializeField] private AudioClip musicClip1;
    [SerializeField] private AudioClip musicClip2;
    [SerializeField] private AudioClip musicClip3;
    [SerializeField] private AudioClip musicClip4;
    [SerializeField] private AudioClip musicClip5;
    [SerializeField] private AudioClip musicClip6;
    private AudioClip[] Soundtrack;
    private void Awake()
    {
        Soundtrack[0] = musicClip1;
        Soundtrack[1] = musicClip2;
        Soundtrack[2] = musicClip3;
        Soundtrack[3] = musicClip4;
        Soundtrack[4] = musicClip5;
        Soundtrack[5] = musicClip6;


        this.gameObject.GetComponent<AudioSource>().clip = musicClip1;
           //Soundtrack[Random.Range(0,Soundtrack.Length)];
        this.gameObject.GetComponent<AudioSource>().Play();

    }
}
