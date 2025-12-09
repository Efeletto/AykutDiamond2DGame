using UnityEngine;
using TMPro;
public class Player_OCT2D : MonoBehaviour
{

    int score = 0;
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
