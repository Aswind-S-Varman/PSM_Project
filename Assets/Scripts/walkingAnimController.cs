using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingAnimController : MonoBehaviour
{
    private Animator walkingAnim;

    private void Start()
    {
        walkingAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            walkingAnim.GetComponent<Animator>().enabled = true;
        }
        else
        {
            //walkingAnim.SetBool("IsMoving", false);
            walkingAnim.GetComponent<Animator>().enabled = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            walkingAnim.GetComponent<Animator>().enabled = true;
        }
    }
}
