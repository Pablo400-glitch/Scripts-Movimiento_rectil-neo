using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class MoveTo : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = goal.position - this.transform.position;
        Quaternion.Slerp(this.transform.rotation, goal.rotation, 0.1f);

        transform.Translate(direction * Time.deltaTime, Space.World);
    }
}
