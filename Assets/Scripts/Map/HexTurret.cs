using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexTurret : Detction_Jeff
{

    public GameObject firePos2, firePos3, firePos4, firePos5, firePos6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detect objects within the detection sphere
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius, layerToDetect);

        foreach (Collider collider in colliders)
        {
            // Perform actions on detected objects
            // For example, shoot a projectile at the detected target
            if (canShoot)
            {
                ShootProjectile();
                StartCoroutine(ShootDelay());
            }
          
        }
    }

    private void ShootProjectile ()
    {
        // Calculate direction towards the target
     

        // Instantiate a projectile at the current position of this object
        GameObject projectile = Instantiate(projectilePrefab, fireposition.transform.position, fireposition.transform.rotation);
        GameObject projectile2 = Instantiate(projectilePrefab, firePos2.transform.position, firePos2.transform.rotation);
        GameObject projectile3 = Instantiate(projectilePrefab, firePos3.transform.position, firePos3.transform.rotation);
        GameObject projectile4 = Instantiate(projectilePrefab, firePos4.transform.position, firePos4.transform.rotation);
        GameObject projectile5 = Instantiate(projectilePrefab, firePos5.transform.position, firePos5.transform.rotation);
        GameObject projectile6 = Instantiate(projectilePrefab, firePos6.transform.position, firePos6.transform.rotation);

        // Get the Rigidbody component of the projectile
        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
        Rigidbody projectileRigidbody2 = projectile2.GetComponent<Rigidbody>();
        Rigidbody projectileRigidbody3 = projectile3.GetComponent<Rigidbody>();
        Rigidbody projectileRigidbody4 = projectile4.GetComponent<Rigidbody>();
        Rigidbody projectileRigidbody5 = projectile5.GetComponent<Rigidbody>();
        Rigidbody projectileRigidbody6 = projectile6.GetComponent<Rigidbody>();

        projectileRigidbody.AddForce(projectile.transform.forward * projectileSpeed, ForceMode.Impulse);
        projectileRigidbody2.AddForce(projectile2.transform.forward * projectileSpeed, ForceMode.Impulse);
        projectileRigidbody3.AddForce(projectile3.transform.forward * projectileSpeed, ForceMode.Impulse);
        projectileRigidbody4.AddForce(projectile4.transform.forward * projectileSpeed, ForceMode.Impulse);
        projectileRigidbody5.AddForce(projectile5.transform.forward * projectileSpeed, ForceMode.Impulse);
        projectileRigidbody6.AddForce(projectile6.transform.forward * projectileSpeed, ForceMode.Impulse);

    }
}
