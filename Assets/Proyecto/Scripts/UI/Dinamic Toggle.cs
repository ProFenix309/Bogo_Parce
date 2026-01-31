using UnityEngine;
using UnityEngine.UI;

public class DinamicToggle : MonoBehaviour
{
    [SerializeField]Toggle toggle;
    public Sprite toggleOn, toggleOff;
    public Image checkmark, offValue;

    private void Start()
    {
        toggle = GetComponent<Toggle>();
        SetImageToggle();
    }
    public void SetImageToggle()
    {
        if (toggle.isOn)
        {
            checkmark.sprite = toggleOn;
            offValue.gameObject.SetActive(false);
        }
        else
        {
            checkmark.sprite = toggleOff;
            offValue.sprite = toggleOff;
            offValue.gameObject.SetActive(true);
        }
    }
}
