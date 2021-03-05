using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem thisParticleSystem;
    void Start()
    {
        thisParticleSystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisParticleSystem.isPlaying) //check if that animation is playing
            {
                return;
            }
        Destroy(gameObject);
    }
}
