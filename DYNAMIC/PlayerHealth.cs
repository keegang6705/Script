//code type : 2D,3D
//code version : 1.0
//last working : unity2022.3.17f

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;

    public TMP_Text healthText; // Reference to UI text to display health

    void Start()
    {
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + currentHealth.ToString();
        }
    }

    public void HealthUpdate(int Health)
    {
        currentHealth += Health;

        currentHealth = Mathf.Max(0, currentHealth);
        currentHealth = Mathf.Min(maxHealth, currentHealth);
        

        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died");
        SceneManager.LoadScene("GameOverScene");
    }
}
