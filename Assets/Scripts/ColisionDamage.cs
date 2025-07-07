using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionDamage : MonoBehaviour
{
    public int pointDamage = 10;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeAll;
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpdateHealth(-pointDamage);
        }
    }
}
