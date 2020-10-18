using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    
    public Vector3 goal = new Vector3(5, 0, 4);

    public float speed = 10f;
    // Start is called before the first frame update
    private void Start()
    {
    }

    private void Update()
    {
    }

    // Update is called once per frame
    private void LateUpdate()
    {
         transform.Translate(goal.normalized * (speed * Time.deltaTime));
    }
}
