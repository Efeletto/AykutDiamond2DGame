using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public SceneManagerGameMenu gameMenu;
    float elapsedTime = 0f;
    public TextMeshProUGUI TimeText;
    public Canvas EscCanvas;
    
    public void Update()
    {
        //Esc ile UI elementini getirme
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //False
            bool isCanvasOpen = EscCanvas.gameObject.activeSelf;
            if (gameMenu.isDead) {
                EscCanvas.gameObject.SetActive(!isCanvasOpen);
            }

            if (isCanvasOpen)
            {
                Time.timeScale = 1f;
            }
            else
            {
                Time.timeScale = 0f;
            }

        }
        elapsedTime += Time.deltaTime;
        TimeUpdater();
    }

    void TimeUpdater()
    {
        int second = Mathf.FloorToInt(elapsedTime % 60);
        int minute = Mathf.FloorToInt(elapsedTime / 60);
        if(second < 10) {
            TimeText.text = $"{minute}:0{second}";
        }
        else
        {
            TimeText.text = $"{minute}:{second}";
        }

    }
}
