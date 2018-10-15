using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uneCollision : MonoBehaviour {
    public GameObject cubeBas;
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "cubeBas")
        {
            Destroy(cubeBas);
            audio.Play();
        }
    }
}
