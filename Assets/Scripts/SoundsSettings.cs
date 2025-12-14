using System.Collections;
using UnityEngine;

public class SoundsSettings : MonoBehaviour
{ public AudioSource audioSource;

    

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1.0f;   
        audioSource.loop = false;
    }

    public void playPart()
    {
        if (!audioSource.isPlaying)
        {
            StartCoroutine(PlayPart());
        }
    }
    IEnumerator PlayPart()
    {
        audioSource.Stop();
        audioSource.time = 0.455f;
        audioSource.Play();
        yield return new WaitForSecondsRealtime(1.6f);
        audioSource.Stop();
    }
}
