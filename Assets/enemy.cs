﻿using UnityEngine;

public class enemy : MonoBehaviour {

    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;



	void Start () {
        target = waypoints.points[0];
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f){
            GetNextWaypoint();
        }
		
	}

    void GetNextWaypoint(){

        if(wavepointIndex >= waypoints.points.Length - 1){
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = waypoints.points[wavepointIndex];
    }
}
