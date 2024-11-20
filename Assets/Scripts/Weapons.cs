using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Pool;
using TMPro;
using UnityEngine.UI;

public class Weapons : MonoBehaviour
{
    public TMP_Text Indicator;
    [SerializeField] Transform barrel;
    [SerializeField] PullZatvor bulletPool;
    private Animator animator;
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private AudioClip shootWithoutBulletSound;
    private int ammoInMagazine = 17;
    [SerializeField] private int magazineSize;
    private AudioSource AudioSource;
    void Start()
    {
        animator = GetComponent<Animator>();
        AudioSource = GetComponent<AudioSource>();
        ammoInMagazine = magazineSize;
    }
    public void Fire()
    {
        if (ammoInMagazine > 0)
        {
            animator.SetTrigger("fire");
            AudioSource.PlayOneShot(shootSound);
            GameObject bullet = bulletPool.GetBullet();
            bullet.transform.position = barrel.transform.position;
            bullet.transform.rotation = barrel.transform.rotation;
            bullet.SetActive(true);
            ammoInMagazine--;
            UpdateIndicator();
        }
        else
        {
            AudioSource.PlayOneShot(shootWithoutBulletSound);
            UpdateIndicator();
        }

    }
    public void Reloading()
    {

        int freeSpaceInMagazine = magazineSize - ammoInMagazine;
        if (AmmoInInventoryScript.bulletsCount >= freeSpaceInMagazine)
        {
            AmmoInInventoryScript.bulletsCount -= (uint)freeSpaceInMagazine;
            ammoInMagazine = magazineSize;
            UpdateIndicator();
        }
        else
        {
            ammoInMagazine += (int)AmmoInInventoryScript.bulletsCount;
            AmmoInInventoryScript.bulletsCount = 0;
            UpdateIndicator();
        }
    }
    public void ExetedMagazine()
    {
        if (ammoInMagazine > 1) 
        {
            AmmoInInventoryScript.bulletsCount += (uint)ammoInMagazine - 1;
            ammoInMagazine = 1;
        }
        UpdateIndicator();
    }
    private void UpdateIndicator()
    {
       Indicator.text = (ammoInMagazine + " / " + magazineSize);
    }
}

