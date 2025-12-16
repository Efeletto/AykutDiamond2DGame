using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour
{
    public SoundsSettings snd;
    private SpriteRenderer sr;
    private Color originColor;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        originColor = sr.color;
    }
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
            StartCoroutine(FlashRed());
            health--;
            canTMP.text = $"Can : {health}";
            if (health == 0) {
                if(PlayerPrefs.GetInt("HighScore",0) < Player_OCT2D.score)
                {
                    PlayerPrefs.SetInt("HighScore", Player_OCT2D.score);
                }
                snd.playPart();
                Time.timeScale = 0f;
                // ölünce esc canvasý açýlmamasý için bool deðiþken ile kontrol ediyoruz
                gameMenu.isDead = false;
                cnvs.gameObject.SetActive(true);
                Debug.Log("You Died!! Game Over!!");

            }
        }
    }

    IEnumerator FlashRed()
    {
        sr.color = Color.red;
        yield return new WaitForSeconds(0.15f);
        sr.color = originColor;
    }

}
