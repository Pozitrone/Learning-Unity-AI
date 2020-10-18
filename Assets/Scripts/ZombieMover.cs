using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMover : MonoBehaviour
{
    
    public Transform goal;
    public float speed = 1f;
    public float accuracy = .1f;
    public float rotationSpeed = 0.5f;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 position = goal.position;
        Vector3 position1 = transform.position;
        Vector3 lookAtGoal = new Vector3(position.x, position1.y, position.z);
        Vector3 direction = lookAtGoal - position1;
        
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * rotationSpeed);

        if (Vector3.Distance(transform.position, lookAtGoal) < accuracy) return;
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
    }
}
