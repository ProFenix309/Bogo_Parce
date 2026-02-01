using UnityEngine;

public class ControladorSalto : MonoBehaviour
{
    [SerializeField] bool estaEnPiso;
    [SerializeField] float fuerzaSalto;
    [SerializeField] GameObject detectorDePiso;
    [SerializeField] Vector3 tamañoDetectorPiso;
    [SerializeField] LayerMask mascaraDePiso;
    [SerializeField] Animator animator;

    private bool estabaSaltando = false;

    private void Start()
    {
        animator.GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        bool estabaPiso = estaEnPiso;
        estaEnPiso = Physics.CheckBox(detectorDePiso.transform.position, tamañoDetectorPiso, Quaternion.identity, mascaraDePiso);
        animator.SetBool("IsGround", estaEnPiso);

        // Detectar cuando el personaje aterriza
        if (!estabaPiso && estaEnPiso && estabaSaltando)
        {
            // Aterrizó - reanudar sonido de correr si se está moviendo
            estabaSaltando = false;
            AudioManager.Instance.ReanudarCorrer();
        }
    }

    public void Saltar()
    {
        Debug.Log("Salto");
        if (estaEnPiso)
        {
            PlayerController.instance.rb.AddForce(0, fuerzaSalto, 0);
            estabaSaltando = true;

            // Detener sonido de correr y reproducir sonido de salto
            AudioManager.Instance.DetenerCorrer();
            AudioManager.Instance.PlaySFX("Salto");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(detectorDePiso.transform.position, tamañoDetectorPiso);
    }
}