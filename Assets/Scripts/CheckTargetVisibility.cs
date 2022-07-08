using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTargetVisibility : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        Debug.DrawRay(transform.position, direction, Color.magenta, 3);
    }
}
