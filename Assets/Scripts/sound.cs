using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource sounddd;
    // Start is called before the first frame update
    void Start()
    {
        sounddd = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            sounddd.mute = true;
        }
        else
        {
            sounddd.mute = false;
        }
        if (Input.GetMouseButtonDown(0))
        {
            sounddd.Play();
        }
    }
}
