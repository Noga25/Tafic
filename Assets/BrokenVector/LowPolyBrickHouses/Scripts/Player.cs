using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject ShootingBeginPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit(Collision Other)
    {
        // Check if bullets reached the target
        if (Other.collider.name == "Bullets")
        {
            transform.position = new Vector3(ShootingBeginPosition.transform.position.x, ShootingBeginPosition.transform.position.y, ShootingBeginPosition.transform.position.z);
        }
    }

}
