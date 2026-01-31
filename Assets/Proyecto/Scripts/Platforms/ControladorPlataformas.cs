using System.Collections;
using UnityEngine;

public class ControladorPlataformas : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject spawnerPlataformas;
    public GameObject conPunRes;
   
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
    
    public void Acativar()
    {
        conPunRes.SetActive(false);
        StartCoroutine(ActivadorPuntos());
    }
    IEnumerator ActivadorPuntos()
    {
        yield return new WaitForSeconds(5);
        conPunRes.SetActive(true);
    }
}
