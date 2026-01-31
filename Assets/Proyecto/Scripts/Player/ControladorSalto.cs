using UnityEngine;

public class ControladorSalto : MonoBehaviour
{
    [SerializeField] bool estaEnPiso;
    [SerializeField] float fuerzaSalto;
    [SerializeField] GameObject detectorDePiso;
    [SerializeField] Vector3 tamañoDetectorPiso;    
    [SerializeField] LayerMask mascaraDePiso;

    private void FixedUpdate()
    {
        estaEnPiso = Physics.CheckBox(detectorDePiso.transform.position, tamañoDetectorPiso, Quaternion.identity, mascaraDePiso);     
    }
    public void Saltar()
    {
        if (estaEnPiso)
        {
            PlayerController.instance.rb.AddForce(0, fuerzaSalto, 0);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(detectorDePiso.transform.position,tamañoDetectorPiso);
    }
}
