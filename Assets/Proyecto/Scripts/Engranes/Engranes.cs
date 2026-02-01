using UnityEngine;

public class Engranes : MonoBehaviour
{
    public float velocidadDeGiro;
    void Update()
    {
        transform.Rotate(0, 0, velocidadDeGiro);
    }
}
