using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTargetVisibility : MonoBehaviour
{
    public Transform target;
    RaycastHit hit;
    Color hitColor = Color.red;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        Debug.DrawRay(transform.position, direction, hitColor, 3);

        if (Physics.Raycast(transform.position, direction, out hit))
        {
            if (hit.transform == target)
            {
                hitColor = Color.green;
            } else hitColor = Color.red;
        }

        Debug.DrawLine(transform.position, target.position, hitColor, 3);
    }
}
