using UnityEngine;
using System.Collections;
using TMPro;

public class UpdateHealthUI : MonoBehaviour
{
    public static TextMeshProUGUI HealthText;

    private void Awake()
    {
        HealthText = GetComponent<TextMeshProUGUI>();
    }
    public static void UpdateHealth(int maxHealth, int currentHealth) => HealthText.text = $"{currentHealth} / {maxHealth}";
    
}
