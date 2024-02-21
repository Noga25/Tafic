using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Transform placeToTeleport;
    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other)
    {
       other.gameObject.transform.Translate(placeToTeleport.position);
    }
}
