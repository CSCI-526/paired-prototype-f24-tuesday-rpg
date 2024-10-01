using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingManager : MonoBehaviour
{
    public GameObject projectilePrefab; 
    public Transform firePoint;         
    public float projectileSpeed = 5f; 
    public float fireRate = 1f;       
    public bool disableGravity = true;  

    private void Start()
    {
        InvokeRepeating("Shoot", 2.0f, fireRate); 
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (disableGravity)
        {
            rb.gravityScale = 0;
        }
        rb.velocity = Vector2.down * projectileSpeed;
    }
}
