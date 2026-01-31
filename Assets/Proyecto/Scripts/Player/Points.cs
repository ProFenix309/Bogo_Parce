using UnityEngine;

public class Points : MonoBehaviour
{
    public int SumPuntos = 1;
    public PlayerController player;
    public GameObject ParticulasDeResiliencia;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            AdministradorDeJuego.instanciAdm.SumadorPuntos(SumPuntos);
            gameObject.SetActive(false);
            Instantiate(ParticulasDeResiliencia,gameObject.transform.position, Quaternion.identity);
            Destroy(ParticulasDeResiliencia, 0.5f);
        }
    }
}
