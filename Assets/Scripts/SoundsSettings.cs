using System.Collections;
using UnityEngine;

public class SoundsSettings : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] deathSounds;

    void Awake()
    {
        audioSource.volume = PlayerPrefs.GetFloat("DeathSound", 0.5f);
    }

    public void playRandomClip()
    {
        int randomIndexOfClip = Random.Range(0, deathSounds.Length);
        audioSource.clip = deathSounds[randomIndexOfClip];
        switch (randomIndexOfClip)
        {
            case 0:
                StartCoroutine(playPartOfClip(0.7f, 1.2f));
                break;

            case 1:
                audioSource.Play();
                break;

            case 2:
                audioSource.Play();
                break;

            case 3:
                audioSource.Play();
                break;

            case 4:
                audioSource.Play();
                break;

            case 5:
                audioSource.Play();
                break;
            case 6:
                StartCoroutine(playPartOfClip(1.1f, 2.4f));
                break;
        }
       //  Debug.Log($"{randomIndexOfClip}");

    }

    System.Collections.IEnumerator playPartOfClip(float startTime, float durationTime)
    {
        audioSource.time = startTime;
        audioSource.Play();
        yield return new WaitForSecondsRealtime(durationTime);
        audioSource.Stop();
    }
    
}
