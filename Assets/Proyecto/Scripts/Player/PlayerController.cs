using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public Rigidbody rb;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
