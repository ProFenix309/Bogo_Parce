using UnityEngine;

public class AudioPaso : MonoBehaviour
{
    public void Pasos()
    {
        AudioManager.Instance.PlaySFX("Correr");
    }
}
