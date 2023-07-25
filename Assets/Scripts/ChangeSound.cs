using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    public Button button;
    private bool isOn = true;

    private AudioSource[] allAudioSources;

    void Start()
    {
        soundOnImage = button.image.sprite;
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImage;
            isOn = false;
            AudioListener.volume = 0f; // Mute all sounds
        }
        else
        {
            button.image.sprite = soundOnImage;
            isOn = true;
            AudioListener.volume = 1f; // Unmute sounds (full volume)
        }
    }
}
