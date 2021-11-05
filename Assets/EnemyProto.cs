using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProto : MonoBehaviour
{
    [SerializeField] private float _Radius;

    public EnemyProto GetFirstEnemyInRange()
    {
        return null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _Radius);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
