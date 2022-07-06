using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticleOnTriggerEnter : MonoBehaviour
{
    ParticleSystem evilTome;

    // Start is called before the first frame update
    void Start()
    {
        evilTome = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.tag == "Player")
         {
             evilTome.Play();
             Debug.Log("Entered Trigger"); 
         }
        
    }
}
