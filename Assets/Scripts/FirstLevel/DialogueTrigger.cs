using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public Canvas QuestionPrompt;
    public Canvas DialogueCanvas;
    public Canvas PauseCanvas;

    //Disable gun
    public GameObject Weapon;
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                // Hide E prompt
                QuestionPrompt.enabled = false;

                // Hide Pause prompt
                PauseCanvas.enabled = false;

                // Stop player movement
                FindObjectOfType<PlayerMovement>().DisableMovement();

                // Give cursor access
                Cursor.lockState = CursorLockMode.None;

                // Lock the weapon
                Weapon.SetActive(false);

                // Activate dialogue canvas
                DialogueCanvas.enabled = true;

                FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);
            }

            if (Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }

        }
    }

    public void ExitButton()
    {
        DialogueCanvas.enabled = false;
        PauseCanvas.enabled = true;
        QuestionPrompt.enabled = true;
        FindObjectOfType<PlayerMovement>().EnableMovement();

        // Lock Cursor
        Cursor.lockState = CursorLockMode.Locked;

        Weapon.SetActive(true);
    }

}
