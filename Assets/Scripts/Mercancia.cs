using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercancia : MonoBehaviour
{
    public int precio;
    public DineroManager dineroManager;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
                //restar precio / puntos
            };
            
        }
    }
}
