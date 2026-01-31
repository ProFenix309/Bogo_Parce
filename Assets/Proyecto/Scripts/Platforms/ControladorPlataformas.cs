using UnityEngine;

public class ControladorPlataformas : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject spawnerPlataformas;
   
    void Update()
    {
        transform.Translate(1 * -speed * Time.deltaTime , 0, 0);
        spawnerPlataformas = GameObject.Find("SpownerPlataformas");
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DetectorPlataformas")
        {
            transform.position = spawnerPlataformas.transform.position;
            
        }
    }
}
