using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detction_Jeff : MonoBehaviour
{
    public float detectionRadius = 3f; // Radius of the detection sphere
    public LayerMask layerToDetect;
    public GameObject projectilePrefab; // Reference to the projectile prefab
    public float projectileSpeed = 10f; // Speed of the projectile
    public GameObject fireposition;
    public float shootingDelay = 1f; // Delay between shots
    public static int shot = 1;

    protected bool canShoot = true; // Flag to control shooting delay

    private void Update()
    {
        // Detect objects within the detection sphere
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius, layerToDetect);

        foreach (Collider collider in colliders)
        {
            // Perform actions on detected objects
            // For example, shoot a projectile at the detected target
            if (canShoot)
            {
                ShootProjectileAtTarget(collider.gameObject.transform);
                StartCoroutine(ShootDelay());
            }
            transform.LookAt(collider.gameObject.transform);
        }
    }

    protected IEnumerator ShootDelay()
    {
        canShoot = false;
        yield return new WaitForSeconds(shootingDelay);
        canShoot = true;
    }

    private void ShootProjectileAtTarget(Transform target)
    {
        // Calculate direction towards the target
        Vector3 direction = (target.position - transform.position).normalized;

        // Instantiate a projectile at the current position of this object
        GameObject projectile = Instantiate(projectilePrefab, fireposition.transform.position, projectilePrefab.transform.rotation);

        // Get the Rigidbody component of the projectile
        Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();

        // Check if the projectile Rigidbody is not null
        if (projectileRigidbody != null)
        {
            // Shoot the projectile towards the target
            projectileRigidbody.AddForce(direction * projectileSpeed, ForceMode.Impulse);
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a wire sphere in the Scene view to represent the detection sphere
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}