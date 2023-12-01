using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particels : MonoBehaviour


{
    public ParticleSystem particleEffect;
    // Start is called before the first frame update
    void Start()
    {
        particleEffect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        particleEffect.Stop(true);   
    }
}
