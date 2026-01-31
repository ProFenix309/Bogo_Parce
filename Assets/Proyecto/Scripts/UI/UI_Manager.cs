using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject pause;
    [SerializeField] GameObject gameOver;

    private void Start()
    {
        ToggleTime(false);
    }

    public void StarButtonUI()
    {
        SceneManager.LoadScene("InGame");
    }

    public void PauseMenuON()
    {
        pause.SetActive(true);
        ToggleTime(false);

    }

    public void PauseMenuOff()
    {
        pause.SetActive(false);
        ToggleTime(true);
    }

    public void ButtonMeinMenu()
    {
        SceneManager.LoadScene("Mein Menu");
    }

    public void ResectButton()
    {
        SceneManager.LoadScene("InGame");
        ToggleTime(true);
    }

    public void GameOverPanel(bool pausa)
    {
        gameOver.SetActive(pausa);
        ToggleTime(false);
    }

    public void ToggleTime(bool time)
    {
        if (time)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }
}
