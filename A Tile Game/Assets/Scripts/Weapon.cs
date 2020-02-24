using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public AudioClip shootSFX;

    AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            //Debug.Log("Shooting Bullet");
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet,firePoint.position, firePoint.rotation);
        _audio.PlayOneShot(shootSFX);
    }
}
