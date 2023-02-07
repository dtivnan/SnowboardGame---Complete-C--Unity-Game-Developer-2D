using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    [SerializeField] ParticleSystem snowTrail;
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "World")
        {
            snowTrail.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "World")
        {
            snowTrail.Stop();
        } 
    }
}
