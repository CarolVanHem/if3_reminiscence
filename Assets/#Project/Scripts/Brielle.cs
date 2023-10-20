using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering.Universal.Internal;

public class Brielle : MonoBehaviour
{
    public enum BrielleState{
        Wandering,
        Chasing
    }

    public BrielleState state;
    NavMeshAgent agent;
    Transform player;
    public Transform waypoints;
    Transform currentTarget;
    public float maxViewDistance = 20;
    public float maxViewAngle = 180;

    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
        state = BrielleState.Wandering;
        SelectWaypoint();
    }

    void Update()
    {
        switch (state)
        {
            case BrielleState.Wandering:
                
                if(IsPlayerVisible()){
                    state = BrielleState.Chasing;
                }
                else{
                    if(IsAtDestination()){
                        SelectWaypoint();
                    }
                }
                
                break;

            case BrielleState.Chasing:
                FollowPlayer();

                if(!IsPlayerVisible()){
                    state = BrielleState.Wandering;
                }
                break;
        }
    }

    bool IsPlayerVisible()
    {
        if(Vector3.Distance(transform.position, player.position) <= maxViewDistance)
        {
            if(Vector3.Angle(transform.forward, player.position - transform.position) <= maxViewAngle)
            {           
                RaycastHit hit;
                Vector3 origin = transform.position + Vector3.up;
                Debug.DrawRay(origin, (player.position-transform.position).normalized * 100, Color.red, 5f);
                if(Physics.Raycast(origin, player.position-transform.position, out hit, maxViewDistance))
                {           
                        
                    if(hit.collider.CompareTag("Player"))
                    {
                    Debug.Log($"{hit.collider.tag} - {hit.collider.name} - {hit.distance}");
                        return true;  
                    }
                }
            }
        }
        return false;
    }

    void FollowPlayer()
    {
        agent.SetDestination(player.position);
    }

    void SelectWaypoint()
    {
        int index = Random.Range(0, waypoints.childCount);

        while(waypoints.GetChild(index) == currentTarget)
        {
            index = Random.Range(0, waypoints.childCount);
        }
        
        currentTarget = waypoints.GetChild(index);
        agent.SetDestination(currentTarget.position);
    }

    private bool IsAtDestination(){
        return agent.remainingDistance <= agent.stoppingDistance;
    }

    private void OnDrawGizmos(){
        Color color = Color.magenta;
        switch(state){
            case BrielleState.Chasing: color = Color.red; break;
            case BrielleState.Wandering: color = Color.cyan; break;
        }
        color.a = 0.2f;
        Gizmos.color = color; 
        Gizmos.DrawSphere(transform.position, maxViewDistance);
    }
}
