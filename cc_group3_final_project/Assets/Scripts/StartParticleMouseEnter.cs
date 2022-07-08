using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticleMouseEnter : MonoBehaviour
{
    ParticleSystem evilTome;

    // Start is called before the first frame update
    
    void Update()
    {

    if(Input.GetMouseButtonDown(0))
    {
        evilTome.Play();
    }
    else
    {
        evilTome.Stop();
    }
    }
}
