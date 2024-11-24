using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.LookAt(goal.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        this.transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        Debug.DrawRay(this.transform.position, direction.normalized * 5.0f, Color.red);
    }
}
