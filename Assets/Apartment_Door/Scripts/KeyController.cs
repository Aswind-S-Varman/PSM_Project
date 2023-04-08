using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Script on Drag and drop will create box collider component automatically
[RequireComponent(typeof(BoxCollider))]
public class KeyController : MonoBehaviour
{
    BoxCollider keyCollider;
    Rigidbody keyRB;
    public GameObject txtToDisplay;
    public DoorController DC;
    public GameObject keyObject;            // Disable key object

    public AudioClip keySound;


    /// <summary>
    /// Incase user forgets to uncheck isTrigger in box collider
    /// This sets them automatically
    /// </summary>
    private void Start()
    {
        keyCollider = GetComponent<BoxCollider>();

        keyCollider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(keySound, transform.position);
            DC.gotKey = true;
            txtToDisplay.GetComponent<TMP_Text>().text = "Key Acquired";
            txtToDisplay.SetActive(true);
            keyObject.SetActive(false);
        }
    }
}
