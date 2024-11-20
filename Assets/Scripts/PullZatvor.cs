using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullZatvor : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    private List<GameObject> Bullets = new List<GameObject>();
    [SerializeField] private int amountToPull;
    void Start()
    {
        GameObject obj;
        for (int i = 0; i < amountToPull; i++)
        {
            obj = Instantiate(bullet);
            obj.SetActive(true);
            Bullets.Add(obj);
        }
    }

    public GameObject GetBullet() 
    {
        foreach (GameObject obj in Bullets)
        { 
            if (!obj.activeInHierarchy)
            {
            return obj;
            }
        }
        return null;
    }
    void Update()
    {
        
    }
}
