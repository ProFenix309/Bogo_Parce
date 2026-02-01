using UnityEngine;

public class ControladorSalto : MonoBehaviour
{
    [SerializeField] bool estaEnPiso;
    [SerializeField] float fuerzaSalto;
    [SerializeField] GameObject detectorDePiso;
    [SerializeField] Vector3 tamañoDetectorPiso;    
    [SerializeField] LayerMask mascaraDePiso;
    [SerializeField] Animator animator;
    


    private void Start()
    {
        animator.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        estaEnPiso = Physics.CheckBox(detectorDePiso.transform.position, tamañoDetectorPiso, Quaternion.identity, mascaraDePiso);
        animator.SetBool("IsGround",estaEnPiso);
        if (estaEnPiso)
        {
            AudioManager.Instance.IniciarCorrer();
        }
 
    }
    public void Saltar()
    {
        Debug.Log("Salto");
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
