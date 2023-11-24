using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTourist : MonoBehaviour
{
    [SerializeField]private List<Vector3> waypoints;
    private Rigidbody _rb;
    private Rigidbody Rb => _rb ??= GetComponent<Rigidbody>();
    private int _currentWaypointIndex = 0;
    private bool _isMovingToNextWaypoint = true;
    
    void Update()
    {
        if (_isMovingToNextWaypoint) {
            MoveToNextWaypoint();
        }
    }

    private void MoveToNextWaypoint()
    {
        Vector3 currentWaypoint = waypoints[_currentWaypointIndex];
        float step = 2f * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, step);

        if (Vector3.Distance(transform.position, currentWaypoint) < 0.1f) {
            if (_currentWaypointIndex + 1 < waypoints.Count) {
                _currentWaypointIndex++;
            }
            else {
                _currentWaypointIndex = 0;
            }

            _isMovingToNextWaypoint = false;
            StartCoroutine(ChangeDirectionAndMoveAfterDelay());
        }
    }

    IEnumerator ChangeDirectionAndMoveAfterDelay()
    {
        yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 5f));

        transform.rotation = Quaternion.Euler(0f, UnityEngine.Random.Range(0f, 360f), 0f);
        _isMovingToNextWaypoint = true;
    }
}

