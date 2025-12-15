using System.Collections;
using UnityEngine;

public class SoundsSettings : MonoBehaviour
{ 

    public AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("DeathSound", 1f);
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
        audioSource.time = 0.7f;
        audioSource.Play();
        yield return new WaitForSecondsRealtime(1.2f);
        audioSource.Stop();
    }
}
