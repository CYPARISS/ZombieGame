using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdle : MonoBehaviour
{
    public Transform player_transform;

    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player_transform.position) < 18f ){
            agent.SetDestination(player_transform.position);
        }
    }
}
