using TMPro;
using UnityEngine;

public class AdministradorDeJuego : MonoBehaviour
{
    public static AdministradorDeJuego instanciAdm;
    [SerializeField] private int puntos;
    public TextMeshProUGUI textoPuntos;
    public TextMeshProUGUI textoPuntosMenu;
    [SerializeField] Camera cam;
    [SerializeField] GameObject muro;
    [SerializeField] GameObject luz;
    [SerializeField] GameObject engrane;
    [SerializeField] GameObject engraneUno;
    [SerializeField] GameObject engraneDos;
    [SerializeField] GameObject engraneTres;
    [SerializeField] GameObject engraneCuatro;
    [SerializeField] GameObject engraneCinco;
    [SerializeField] GameObject enemies;
    [SerializeField] GameObject enemiesDos;

    public int Puntos { get => puntos; set => puntos = value; }

    private void Awake()
    {
        if (instanciAdm == null)
        {
            instanciAdm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        puntos = 0;
        enemiesDos.SetActive(false);

    }

    public void SumadorPuntos(int sumadorPuntos)
    {
        Puntos += sumadorPuntos;
        textoPuntos.text = Puntos.ToString();
        textoPuntosMenu.text = Puntos.ToString();


    }
    public void Portal()
    {
        
        //camara
        cam.transform.rotation = Quaternion.Euler(0, 180, 180);
        cam.transform.position = new Vector3(0, 1, 10);
        //Muro
        muro.transform.position = new Vector3(0.59f, 4.0066f, -3.74f);
        //luz
        //luz.transform.position = new Vector3(0, -11, 0);
        luz.transform.rotation = Quaternion.Euler(49.346f, -150.441f, -132.861f);
        //engranes
        engrane.transform.position = new Vector3(-12.0312f, 2.4294f, -4.6f);
        engraneUno.transform.position = new Vector3(-7.7f, 6.4822f, -4.51f);
        engraneDos.transform.position = new Vector3(-2f, 7.446f, -4.51f);
        engraneTres.transform.position = new Vector3(6.93f, 8.15f, -4.11f);
        engraneCuatro.transform.position = new Vector3(9.92f, 6.13f, -4.11f);
        engraneCinco.transform.position = new Vector3(12.91f, 4.09f, -4.11f);
        //Enemies
        enemies.SetActive(false);
        enemiesDos.SetActive(true);

    }
    public void PortalDos()
    {
        //camara
        cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        cam.transform.position = new Vector3(0, 1, -10);
        //Muro
        muro.transform.position = new Vector3(0.59f, 4.0066f, 3.74f);
        //luz
        //luz.transform.position = new Vector3(0, 3, 0);
        luz.transform.rotation = Quaternion.Euler(50, -30, 0);
        //Engranes
        engrane.transform.position = new Vector3(-12.0312f, 2.4294f, 1.71f);
        engraneUno.transform.position = new Vector3(-7.7f, 6.4822f, 1.8f);
        engraneDos.transform.position = new Vector3(-2f, 7.446f, 1.8f);
        engraneTres.transform.position = new Vector3(6.93f, 8.15f, 2.2f);
        engraneCuatro.transform.position = new Vector3(9.92f, 6.13f, 2.2f);
        engraneCinco.transform.position = new Vector3(12.91f, 4.09f, 2.2f);
        //Enemies
        enemies.SetActive(true);
        enemiesDos.SetActive(false);


    }
}
