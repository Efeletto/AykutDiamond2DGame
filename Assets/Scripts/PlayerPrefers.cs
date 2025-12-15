using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefers : MonoBehaviour
{
    public Slider volumeSlider;
    
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("DeathSound", 1f);
    }

    public void OnSliderChanged()
    {
        PlayerPrefs.SetFloat("DeathSound",volumeSlider.value);
    }

}
