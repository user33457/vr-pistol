using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class Weapons : MonoBehaviour
{
    [SerializeField] Transform barrel;
    [SerializeField] PullZatvor bulletPool;
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Fire() 
    {
        animator.SetTrigger("fire");
        GameObject bullet = bulletPool.GetBullet();
        bullet.transform.position = barrel.transform.position;
        bullet.transform.rotation = barrel.transform.rotation;
        bullet.SetActive(true);
        //RaycastHit hit;
        //if(Physics.Raycast(barrel.transform.position, barrel.transform.forward, out hit)) 
        //{
        //    Target target = hit.transform.GetComponent<Target>();
        //    if (target != null)
        //    { 
        //        Destroy(target.gameObject); 
        //    }
        //}
    }
}
