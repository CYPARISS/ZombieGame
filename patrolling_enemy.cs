using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class patrolling_enemy : MonoBehaviour
{
    public Transform player_transform;

    NavMeshAgent agent;

    public Transform[] points;

    int index = 0;

    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        print(points[index]);
        UpdateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(transform.position, player_transform.position) < 18f ){
            agent.SetDestination(player_transform.position);
        }else if(Vector3.Distance(transform.position, player_transform.position) >= 18f ){
            agent.SetDestination(target);
        }
        
        if(Vector3.Distance(transform.position, target) < 2f ){
            IterateIndex();
            UpdateDestination();
        }
    }
    void UpdateDestination(){
        target = points[index].position;
        agent.SetDestination(target);
    }
    void IterateIndex()
    {
        index++;
        
        if(index == points.Length)
        {
            index = 0;
        }
    }
}
