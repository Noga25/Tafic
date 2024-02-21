using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAi : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform finalDestantion;
    [SerializeField] Transform Player;
    [SerializeField] Rigidbody rb;
    [SerializeField]int AttackDistance = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(finalDestantion.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.transform.position,this.transform.position)<= AttackDistance)
        {
            agent.SetDestination(Player.transform.position) ;
        }
        if (Vector3.Distance(this.transform.position,Player.transform.position)<=1.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
