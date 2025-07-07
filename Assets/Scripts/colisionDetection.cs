using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionDetection : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto con " + collision.gameObject);
        Destroy(collision.gameObject);
    }
}
