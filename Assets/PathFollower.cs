using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _arrivalThreshold;

    private path _path;
    private WayPoint _currentWaypoint;
    // Start is called before the first frame update
    void Start()
    {
        SetupPath();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.LookAt(_currentWaypoint.GetPosition());
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        float distanceToWaypoint = Vector3.Distance(transform.position, _currentWaypoint.GetPosition());
        if (distanceToWaypoint <= _arrivalThreshold)
        {
            if (_currentWaypoint == _path.GetPathEnd())
            {
                pathComplete();
            }
            else
            {
                _currentWaypoint = _path.GetNextWaypoint(_currentWaypoint);
            }
        }
    }
    void SetupPath()
    {
        _path = FindObjectOfType<path>();
        _currentWaypoint = _path.GetPathStart();
    }


    void pathComplete()
    {
        Destroy(gameObject);
    }
}
