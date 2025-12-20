using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class SoundsSettings : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] deathSounds;
    //ölünce çýkacak olan yazý
    public TextMeshProUGUI cnvs;

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
                cnvs.rectTransform.anchoredPosition = new Vector2(-23.4f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(295.29f, 50f);
                cnvs.text = "Baba Çok Zor Ya !";
                break;

            case 1:
                StartCoroutine(playPartOfClip(0.6f,1f));
                cnvs.rectTransform.anchoredPosition = new Vector2(-9.5f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(330.8f, 50f);
                cnvs.text = "B*k Mu Yedin Sen ?";
                break;

            case 2:
                audioSource.Play();
                cnvs.rectTransform.anchoredPosition = new Vector2(-25.9f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(330.8f, 50f);
                cnvs.text = "Hadi Yaþa Hadi G*t !";
                break;

            case 3:
                audioSource.Play();
                cnvs.rectTransform.anchoredPosition = new Vector2(-19.5f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(253f, 50f);
                cnvs.text = "Ya Noluyor Be !";
                break;

            case 4:
                audioSource.Play();
                cnvs.rectTransform.anchoredPosition = new Vector2(-2.3f,87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(521f,50f);
                cnvs.text = "Ya Oyun Gitti Niye Çekiyon Fiþi !";
                break;

            case 5:
                audioSource.Play();
                cnvs.rectTransform.anchoredPosition = new Vector2(-18.5f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(460.67f, 50f);
                cnvs.text = "Yavaþ Lan Gaç Tane Alýyon !";
                break;
            case 6:
                StartCoroutine(playPartOfClip(1.1f, 2.4f));
                cnvs.rectTransform.anchoredPosition = new Vector2(-30.4f, 87.5f);
                cnvs.rectTransform.sizeDelta = new Vector2(573.5f, 50f);
                cnvs.text = "Uður Bey Çorbanýza B*k Gibi Dedi !";
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
