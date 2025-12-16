using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class SceneSettings : MonoBehaviour
{
    public GameObject panelSettings;
    public TextMeshProUGUI HighScore;
    private void Awake()
    {
        HighScore.text = $"High Score : {PlayerPrefs.GetInt("HighScore",0)}";
    }

    private void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }
    private void openSettingsPanel()
    {
        panelSettings.SetActive(true);
    }
    private void closeSettingsPanel()
    {
        panelSettings.SetActive(false);
    }
    private void QuitGame()
    {
        Application.Quit();
    }


}
