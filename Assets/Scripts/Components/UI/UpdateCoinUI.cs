using UnityEngine;
using TMPro;
using System.Collections;

public class UpdateCoinUI : MonoBehaviour
{
    public static TextMeshProUGUI CoinText;

    private void Awake()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }
    public static void UpdateCoinText(int coins) => CoinText.text = $"{coins}";

}
