using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    // Start is called before the first frame update
    public void UpdateHealth(float points)
    {
        if (playerHealth + points <= 0)
        {
            SceneManager.LoadScene("Fps Parkour");
        }
        else
        {
            playerHealth += points;
        }
    }

}
