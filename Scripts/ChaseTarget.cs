using UnityEngine;
using UnityStandardAssets.Utility;

public class ChaseTarget : MonoBehaviour
{
    public WaypointCircuit circuit;
    public float speed = 3f;
    public float accuracy = 0.5f;

    private int currentWaypointIndex = 0;

    void Start()
    {
        if (circuit == null)
        {
            circuit = FindObjectOfType<WaypointCircuit>();
        }
    }

    void Update()
    {
        if (circuit.Waypoints.Length == 0) return;

        Transform target = circuit.Waypoints[currentWaypointIndex];

        Vector3 direction = (target.position - transform.position).normalized;

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > accuracy)
        {
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);

            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % circuit.Waypoints.Length;
        }
    }
}
