using UnityEngine;

public class ControladorPlataformas : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime , 0, 0);
    }
}
