using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject pause;

    public void StarButtonUI()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PauseMenuON()
    {
        pause.SetActive(true);
    }

    public void PauseMenuOff()
    {
        pause.SetActive(false);
    }

    public void ButtonMeinMenu()
    {
        SceneManager.LoadScene("Mein Menu");
    }

    public void ResectButton()
    {
        SceneManager.LoadScene("Level 1");
    }
}
