using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_InputField InputMoney;
    public DineroManager dineroManager;

    public TMP_InputField Inputlife;
    public HealthManager healthManager;

    // Update is called once per frame
    void Update()
    {
        InputMoney.text = dineroManager.playerMoney.ToString();
        Inputlife.text = healthManager.playerHealth.ToString();
    }
}
