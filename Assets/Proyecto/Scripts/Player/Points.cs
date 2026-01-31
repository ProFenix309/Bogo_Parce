using UnityEngine;

public class Points : MonoBehaviour
{
    public int SumPuntos = 1;
    public PlayerController player;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            AdministradorDeJuego.instanciAdm.SumadorPuntos(SumPuntos);
        }
    }
}
