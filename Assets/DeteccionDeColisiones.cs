using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
