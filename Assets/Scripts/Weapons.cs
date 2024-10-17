using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    [SerializeField] Transform barrel;
    void Start()
    {
        
    }
    public void Fire() 
    {
        RaycastHit hit;
        if(Physics.Raycast(barrel.transform.position, barrel.transform.forward, out hit)) 
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            { 
                Destroy(target.gameObject); 
            }
        }
    }
}
