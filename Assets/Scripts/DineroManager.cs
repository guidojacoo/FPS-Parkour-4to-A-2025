using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney = 100f;

    public bool UpdateMoney(float amount)
    {
        if (playerMoney + amount < 0)
        {
            return false;
        }
        else
        {
            playerMoney += amount;
            return true;
        }
    }
}