using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRoaming : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform WaypointContainer;
    public Transform[] waypoints;
    public BaseEnemy[] enemy;
    private Transform[] waypoint;
    private int currentWaypoint = 0;
    public float distanceToCover = 1f;

    private float[] distanceLeftToTravel;



    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(WaypointContainer)
        {
            GetWaypoints();
        }
        waypoint = new Transform[enemy.Length];
        distanceLeftToTravel = new float[enemy.Length];

        for (int i = 0; i < enemy.Length; i++)
        {
            distanceLeftToTravel[i] = float.MaxValue;
        }
    }

    public void RoamingPath()
    {
        Vector3 RelativeWaypointPosition = transform.InverseTransformPoint(new Vector3(waypoints[currentWaypoint].position.x, transform.position.y, waypoints[currentWaypoint].position.z));

        for (int i = 0; i < enemy.Length; i++)
        {
            Transform nextWaypoint = GetCurrentWaypoint();
            float distanceCovered = (nextWaypoint.position - transform.position).magnitude;

            if (distanceLeftToTravel[i] - distanceToCover > distanceCovered ||
                waypoint[i] != nextWaypoint)
            {
                waypoint[i] = nextWaypoint;
                distanceLeftToTravel[i] = distanceCovered;
            }

            if (RelativeWaypointPosition.magnitude < 5)
            {
                currentWaypoint++;
                if (currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            agent.SetDestination(GetCurrentWaypoint().position);
        }
    }

    void GetWaypoints()
    {
        Transform[] potentialWaypoints = WaypointContainer.GetComponentsInChildren<Transform>();
        waypoints = new Transform[(potentialWaypoints.Length - 1)];

        for (int i = 1; i < potentialWaypoints.Length; i++)
        {
            waypoints[i - 1] = potentialWaypoints[i];
        }
    }

    public NavMeshAgent GetNavMeshAgent()
    {
        return agent;
    }

    public Transform GetCurrentWaypoint()
    {
        return waypoints[currentWaypoint];
    }

}
