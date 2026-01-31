using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject pause;

    public void StarButtonUI()
    {
        SceneManager.LoadScene("InGame");
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
    }

    public void Test()
    {
        Debug.Log("Hit");
    }
}
