using System.Collections;
using UnityEngine;

public class PortalDos : MonoBehaviour
{
    public MeshRenderer mesh;
    public BoxCollider coll;
    public int contador = 0;
    [SerializeField] GameObject portalDos;
    private void Start()

    {
        portalDos.SetActive(false);        
        coll.enabled = false;
    }
    private void Update()
    {
        if (contador == 0)
        {
            StartCoroutine(SpownPortalDos());
            contador++;
        }
        else
        {
            return;
        }
    }
    IEnumerator SpownPortalDos()
    {
        yield return new WaitForSeconds(45);
        portalDos.SetActive(true);
        coll.enabled = true;
        yield return new WaitForSeconds(5);
        portalDos.SetActive(false);
        coll.enabled = false;
        yield return new WaitForSeconds(50);
        contador = 0;


    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            AdministradorDeJuego.instanciAdm.PortalDos();
        }
    }
}
