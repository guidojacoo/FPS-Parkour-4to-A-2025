using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercancia : MonoBehaviour
{
    public int scorePoints;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            // sumar puntos al score 
        }
    }
    
}
