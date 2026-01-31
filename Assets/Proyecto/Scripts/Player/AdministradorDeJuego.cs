using TMPro;
using UnityEngine;

public class AdministradorDeJuego : MonoBehaviour
{
    public static AdministradorDeJuego instanciAdm;
    [SerializeField] private int puntos;
    public TextMeshProUGUI textoPuntos;
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
}
