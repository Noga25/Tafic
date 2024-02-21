using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] GameObject Bullets;
    [SerializeField] GameObject ShootingBeginPosition;
    [SerializeField] Transform target; // Target GameObject to move the bullet towards

    private bool isLaunching = false; // Flag to track if bullet is currently launching
    private float launchDuration = 1.0f; // Duration of the launch in seconds
    private float launchTimer = 0.0f; // Timer for tracking launch progress
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter trigger");

        LaunchBullet();
    }

    void Update()
    {
        Debug.Log(isLaunching);
        if (isLaunching)
        {
            //GameObject newBullet = Instantiate(Bullets, Bullets.transform.position, Quaternion.identity);

            // Move the bullets GameObject towards the target
            Bullets.transform.position = Vector3.MoveTowards(Bullets.transform.position, target.position, 24 * Time.deltaTime);
        }

        if(Vector3.Distance(Bullets.transform.position, target.position) < 1.5)
        {
            isLaunching = false;
            transform.position = new Vector3(ShootingBeginPosition.transform.position.x, ShootingBeginPosition.transform.position.y, ShootingBeginPosition.transform.position.z);
            Debug.Log(Vector3.Distance(Bullets.transform.position, target.position));
            Destroy(target.gameObject);
        }
    }

    void LaunchBullet()
    {
        // Check if the bullets GameObject and target are assigned
        if (Bullets == null || target == null)
        {
            Debug.LogWarning("Bullets GameObject or target is not assigned.");
            return;
        }

        // Set launch flag to true
        isLaunching = true;
    }
}
