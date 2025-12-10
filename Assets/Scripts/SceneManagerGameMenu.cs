using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerGameMenu : MonoBehaviour
{
    public Canvas EscCanvas;
    public void RetryGame()
    {
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
        SceneManager.LoadScene("MainMenuScene");
    }
}
