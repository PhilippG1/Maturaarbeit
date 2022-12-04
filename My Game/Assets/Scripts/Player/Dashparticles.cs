using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashparticles : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        GetComponent<ParticleSystem>().Pause();
    }
}
