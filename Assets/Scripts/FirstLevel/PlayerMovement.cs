using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jump = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public bool canMove = true;

    // Coins collection
    public int NumberOfCoins { get; private set; }

    public UnityEvent<PlayerMovement> OnCoinCollected;

    public AudioSource jumpSoundEffect;

    public AudioSource footstepsSound;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += DisableMovement;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= DisableMovement;
    }

    void Update()
    {
       if (canMove)
        {
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded && PauseMenu.GameIsPaused == false)
            {
                velocity.y = Mathf.Sqrt(jump * -2f * gravity);
                jumpSoundEffect.Play();
            }

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);


            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                footstepsSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = false;
            }
        }
    }

    public void CoinsCollected()
    {
        NumberOfCoins++;
        OnCoinCollected.Invoke(this);
    }

    public void DisableMovement()
    {
        canMove = false;
        footstepsSound.enabled = false;
    }

    public void EnableMovement()
    {
        canMove = true;
    }

}