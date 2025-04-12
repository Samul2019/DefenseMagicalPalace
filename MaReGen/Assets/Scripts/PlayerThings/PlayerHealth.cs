using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    [SerializeField] private int CurrentHealth;

    [SerializeField] private GameObject gameOverCanvas;

    [SerializeField] private Image[] hearts; 
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        Debug.Log("Salud actual = " + CurrentHealth);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LoseHealth();
            Debug.Log("Chocó y le hizo daño. Salud actual = " + CurrentHealth);
            collision.gameObject.SetActive(false);

        }
    }

    private void LoseHealth()
    {
        CurrentHealth--;
        UpdateHealthUI();
        if (CurrentHealth <= 0) {

            CharacterDeath();
        }

    }
    private void CharacterDeath()
    {
        gameOverCanvas.SetActive(true);
    }

    void UpdateHealthUI()
    {
        // Recorrer todos los corazones y desactivarlos si la salud ha disminuido
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < CurrentHealth)
            {
                hearts[i].enabled = true; // Activa el corazón si está dentro del rango de salud
            }
            else
            {
                hearts[i].enabled = false; // Desactiva el corazón si la salud es menor
            }
        }
    }
}
