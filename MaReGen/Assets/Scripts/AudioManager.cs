using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource audioSource;

    void Awake()
    {
        // Singleton clásico
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Para que no se destruya entre escenas
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Función para reproducir sonidos
    public void ReproducirSonido(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}