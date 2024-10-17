using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int impulseForBarrel;
    private Rigidbody rb;
    void Start()
    {
        rb.AddForce(transform.forward * impulseForBarrel, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
