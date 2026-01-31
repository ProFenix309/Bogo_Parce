using UnityEngine;

public class Points : MonoBehaviour
{
    public int SumPuntos = 1;
    public PlayerController player;
    public GameObject prefabParticulasDeResiliencia;
    private GameObject instanciaParticulas;
    public Transform spowner;

    private void Update()
    {
        if(gameObject.transform.position.x ==spowner.transform.position.x)
        {
            gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {            
            AdministradorDeJuego.instanciAdm.SumadorPuntos(SumPuntos);
            gameObject.SetActive(false);
            instanciaParticulas = Instantiate(prefabParticulasDeResiliencia,gameObject.transform.position, Quaternion.identity);
            Destroy(instanciaParticulas, 1);
        }
    }
}
