using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AnimationEventReciever : MonoBehaviour
{
    public AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFootstepSound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
