using TMPro;
using UnityEngine;

public class AdministradorDeJuego : MonoBehaviour
{
    public static AdministradorDeJuego instanciAdm;
    [SerializeField] private int puntos;
    public TextMeshProUGUI textoPuntos;
    [SerializeField] Camera cam;
    [SerializeField] GameObject muro;
    [SerializeField] GameObject luz;
   
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
    }

    public void SumadorPuntos(int sumadorPuntos)
    {
        Puntos += sumadorPuntos;
        textoPuntos.text = Puntos.ToString();
        
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

    }
    public void PortalDos()
    {
        //camara
        cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        cam.transform.position = new Vector3(0, 1, -10);
        //Muro
        muro.transform.position = new Vector3(0.59f, 4.0066f, 3.3f);
        //luz
        //luz.transform.position = new Vector3(0, 3, 0);
        luz.transform.rotation = Quaternion.Euler(50, -30, 0);

    }
}
