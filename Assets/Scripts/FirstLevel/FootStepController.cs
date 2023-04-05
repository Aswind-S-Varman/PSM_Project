using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepController : MonoBehaviour
{
    public AudioSource footstepsSound;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
           footstepsSound.enabled = true;
        }
        else
        {
            footstepsSound.enabled = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            footstepsSound.enabled = false;
        }
    }
}