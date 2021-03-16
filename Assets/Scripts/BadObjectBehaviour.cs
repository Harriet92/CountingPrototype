using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadObjectBehaviour : MonoBehaviour
{
    public ParticleSystem boomParticles;
    

	private void OnCollisionEnter(Collision collision)
	{
        Instantiate(boomParticles, transform.position, boomParticles.transform.rotation);
        Destroy(gameObject);
    }
}
