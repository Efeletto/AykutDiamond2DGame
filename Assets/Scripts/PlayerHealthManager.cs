using UnityEngine;
using TMPro;

public class PlayerHealthManager : MonoBehaviour
{
    public TextMeshProUGUI GameOverTMP;
    public TextMeshProUGUI canTMP;
    private int health = 3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bok")) {  
            health--;
            canTMP.text = $"Can : {health}";
            if (health == 0) {
                GameOverTMP.gameObject.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("öldün yarra yedin !!! ");           
            }
        }
    }
}
