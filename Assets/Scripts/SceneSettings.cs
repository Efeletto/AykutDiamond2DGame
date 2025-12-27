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

    public void StartGame()
    {
        StartCoroutine(waitSecondsBeforeLoad());
    }
    public void openCloseSettingsPanel()
    {
        if (panelSettings.activeInHierarchy)
        {
            panelSettings.SetActive(false);
        }
        else {
            panelSettings.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    System.Collections.IEnumerator waitSecondsBeforeLoad(float seconds = 0.1f)
    {
        yield return new WaitForSecondsRealtime(seconds);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
    }
}
