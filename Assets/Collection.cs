using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    public AudioClip collect;
    public AudioSource audio;
    private int count;
    public Text countText;
    
    // Start is called before the first frame update
    void Start() {
        audio = GetComponent<AudioSource>();
        count = 0;
        SetCountText();
    }
    // Update is called once per frame
        void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pick Up")) {
            audio.PlayOneShot(collect);
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    void SetCountText() {
        if (count >= 30) {
            countText.text = "All Items Collected";
        } else {
            countText.text = "Items Collected: " + count.ToString() + "/30";
        }
    }
}
