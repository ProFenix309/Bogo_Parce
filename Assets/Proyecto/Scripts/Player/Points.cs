using System.Collections;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int SumPuntos = 1;
    public PlayerController player;
    public GameObject prefabParticulasDeResiliencia;
    private GameObject instanciaParticulas;
 
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            AdministradorDeJuego.instanciAdm.SumadorPuntos(SumPuntos);            
            instanciaParticulas = Instantiate(prefabParticulasDeResiliencia,gameObject.transform.position, Quaternion.identity);
            Destroy(instanciaParticulas, 1);
            transform.parent.GetComponent<ControladorPlataformas>().Acativar();
            AudioManager.Instance.PlaySFX("Point");
        }
    }

}
