using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject pause;
    [SerializeField] GameObject gameOver;

    public void StarButtonUI()
    {
        SceneManager.LoadScene("HIstoria");
    }

    public void PauseMenuON()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PauseMenuOff()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ButtonMeinMenu()
    {
        SceneManager.LoadScene("Mein Menu");
    }

    public void ResectButton()
    {
        SceneManager.LoadScene("InGame");
        Time.timeScale = 1f;
    }

    public void GameOverPanel(bool pausa)
    {
        gameOver.SetActive(pausa);
        Time.timeScale = 0f;
    }
}
