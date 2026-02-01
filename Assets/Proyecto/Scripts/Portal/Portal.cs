using System.Collections;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public MeshRenderer mesh;
    public BoxCollider coll;
    public int counter = 0;

    private void Start()
    {
        mesh.enabled = false;
        coll.enabled = false;
    }
    private void Update()
    {
        if(counter == 0)
        {
            StartCoroutine(SpownPortal());
            counter++;
        }
        else
        {
            return;
        }
        
    }
    IEnumerator SpownPortal()
    {
        yield return new WaitForSeconds(25);
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
            Debug.Log("toco el player");
            AdministradorDeJuego.instanciAdm.Portal();
        }
    }
}
