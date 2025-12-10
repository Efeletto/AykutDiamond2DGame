using UnityEngine;
using TMPro;

public class PlayerHealthManager : MonoBehaviour
{
    // ...
    public SceneManagerGameMenu gameMenu;

    // canýmýzý gösteren TMP
    public TextMeshProUGUI canTMP;

    // can deðiþkenimiz
    private int health = 3;

    //ölünce gelecek olan canvas
    public Canvas cnvs;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bok")) {  
            health--;
            canTMP.text = $"Can : {health}";
            if (health == 0) {
                Time.timeScale = 0f;
                // ölünce esc canvasý açýlmamasý için bool deðiþken ile kontrol ediyoruz
                gameMenu.isDead = false;
                cnvs.gameObject.SetActive(true);
                Debug.Log("öldün yarra yedin !!! ");           
            }
        }
    }
}
