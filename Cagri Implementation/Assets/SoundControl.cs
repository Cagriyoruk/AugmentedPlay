﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btnName;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "Button1":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        break;
                    case "Button2":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "Button3":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "Button4":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "Button5":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "Button6":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    case "Button7":
                        myAudioSource.clip = aClips[6];
                        myAudioSource.Play();
                        break;
                    case "Button8":
                        myAudioSource.clip = aClips[7];
                        myAudioSource.Play();
                        break;
                    case "Button9":
                        myAudioSource.clip = aClips[8];
                        myAudioSource.Play();
                        break;
                    case "Button10":
                        myAudioSource.clip = aClips[9];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
