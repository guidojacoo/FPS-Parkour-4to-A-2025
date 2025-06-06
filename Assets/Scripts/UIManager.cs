using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyText;
    private DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
        UpdateMoneyUI();
    }

    void Update()
    {
        if (dineroManager != null && moneyText != null)
        {
            UpdateMoneyUI();
        }
    }

    void UpdateMoneyUI()
    {
        moneyText.text = "Dinero: $" + dineroManager.playerMoney.ToString("F0");
    }
}