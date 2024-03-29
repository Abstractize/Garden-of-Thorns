﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{

    public float speed = 1200f;
    public float nextWaypointDistance = 3f;
    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;
    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f,0.5f);
    }

    void UpdatePath(){
        seeker.StartPath(rb.position,GetClosestObject("Player").transform.position,OnPathComplete);
    }

    void OnPathComplete(Path p){
        if(!p.error){
            path = p;
            currentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null){
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count){
            reachedEndOfPath = true;
            return;
        }
        else{
            reachedEndOfPath = false;
        }
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position,path.vectorPath[currentWaypoint]);

        if(distance < nextWaypointDistance){
            currentWaypoint++;
        }

    }

    public GameObject GetClosestObject(string tag)
    {
        float distanceToClosestEnemy = Mathf.Infinity;
        GameObject closest = gameObject;
        GameObject[] obj = GameObject.FindGameObjectsWithTag(tag);
        

        foreach(GameObject current in obj)
        {
            float distanceToEnemy = (current.transform.position - this.transform.position).sqrMagnitude;
            if (distanceToEnemy < 500.0f){
                if (distanceToEnemy < distanceToClosestEnemy)
                {
                    distanceToClosestEnemy = distanceToEnemy;
                    closest = current;
                }
            }       
        }
        Debug.DrawLine(this.transform.position, closest.transform.position);
        return closest;
    }
}
