using System.Collections;
using UnityEngine;

public class PortalDos : MonoBehaviour
{
    public MeshRenderer mesh;
    public BoxCollider coll;
    public int contador = 0;
    private void Start()
    {
        mesh.enabled = false;
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
        mesh.enabled = true;
        coll.enabled = true;
        yield return new WaitForSeconds(5);
        mesh.enabled = false;
        coll.enabled = false;


    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            AdministradorDeJuego.instanciAdm.PortalDos();
        }
    }
}
