using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public AudioClip collect;
    public AudioSource audio;
    
    // Start is called before the first frame update
    void Start() {
        audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
        void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up")) {
            audio.PlayOneShot(collect);
            other.gameObject.SetActive(false);
            
        }
    }

}
