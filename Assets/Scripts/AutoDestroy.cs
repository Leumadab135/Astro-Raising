using UnityEngine;

public class AutoDestroyEffect : MonoBehaviour
{
    public float lifetime = 1.3f; // Tiempo en segundos antes de que el objeto se destruya

    void Start()
    {
        // Inicia la destrucci�n despu�s del tiempo especificado
        Destroy(gameObject, lifetime);
    }
}

