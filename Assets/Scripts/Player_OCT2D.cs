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
        Destroy(collision.gameObject);
        score++;
        MyText.text = $"Score : {score}";
        }

        // Bok ile olan collision
        if(collision.gameObject.tag == "Bok")
        {
            Destroy(collision.gameObject);
        }
    }

}
