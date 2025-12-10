using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSettings : MonoBehaviour
{
    public GameObject panelSettings;

   
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void openSettingsPanel()
    {
        panelSettings.SetActive(true);
    }
    public void closeSettingsPanel()
    {
        panelSettings.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
