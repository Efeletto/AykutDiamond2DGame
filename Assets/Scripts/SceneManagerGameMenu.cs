using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGameMenu : MonoBehaviour
{
    public Canvas EscCanvas;
    public bool isDead = true;

    //Esc Canvas Ayarlarý
    public void RetryGame()
    {
        // Ayný butonu öldükten sonra gelen retry butonunda da kullandým
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }
    public void ResumeGame()
    {
        EscCanvas.gameObject.SetActive(false);
        Time.timeScale = 1f;

    }
    public void ExitGame()
    {
        // Ayný butonu öldükten sonra gelen exit butonunda da kullandým
        SceneManager.LoadScene("MainMenuScene");
    }

}
