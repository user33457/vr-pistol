using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int impulseForBarrel;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * impulseForBarrel, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 5) 
        {
            gameObject.SetActive(false); 
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        Target target = other.gameObject.GetComponent<Target>();
        if (target != null) 
        {
            Destroy(target.gameObject);
            gameObject.SetActive(false);
        } 
    }
}
