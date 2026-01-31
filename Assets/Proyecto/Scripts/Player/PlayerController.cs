using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public Rigidbody rb;
    public UI_Manager ui;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ui == null)
        {
            return;
        } 
            
        if (collision.gameObject.tag == "FinDelJuego")
        {
            ui.GameOverPanel(true);
        }
    }

}
