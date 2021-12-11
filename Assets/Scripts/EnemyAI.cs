using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] NavMeshAgent agent;

    [SerializeField] GameObject player;

    ArrayList players = new ArrayList();

    [SerializeField] float detectionRange;


    private void Start()
    {
        players.Add(player);
    }

    void Update()
    {

        if(Vector3.Distance(transform.position, getNearestTarget(agent, players).transform.position) <= detectionRange)
        {
            moveAgentToObject(agent, player);
        }

    }


    void moveAgentToObject(NavMeshAgent _agent, GameObject target)
    {
        //_agent.SetDestination(target.transform.position);
        _agent.SetDestination(getNearestTarget(agent, players).transform.position);
    }





    GameObject getNearestTarget(NavMeshAgent _agent, ArrayList targets)
    {
        GameObject nearestTarget = null;

        foreach (GameObject target in targets)
        {
            if (nearestTarget == null)
            {
                nearestTarget = target;
            }
            else if (Vector3.Distance(target.transform.position, _agent.transform.position) < Vector3.Distance(nearestTarget.transform.position, _agent.transform.position))
            {
                nearestTarget = target;
            }
        }

        return nearestTarget;
    }



}
