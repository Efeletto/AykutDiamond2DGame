using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
public class Player_OCT2D : MonoBehaviour
{

    public static int score = 0;
    public TextMeshProUGUI MyText;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Yemek ile olan collision
        if(collision.gameObject.CompareTag("Yemek")) { 
        collision.gameObject.SetActive(false);
        score++;
        MyText.text = $"Score : {score}";
        }

        // Bok ile olan collision
        if(collision.gameObject.tag == "Bok")
        {
            collision.gameObject.SetActive(false);
        }
    }

}
