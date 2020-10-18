using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGoalMover : MonoBehaviour
{

    public Transform goal;
    public float speed;
    public float accuracy = .1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 direction = goal.position - transform.position;
        if (direction.magnitude < accuracy) return;
        transform.Translate(direction.normalized * (speed * Time.deltaTime), Space.World);
        transform.LookAt(goal);
    }
}
