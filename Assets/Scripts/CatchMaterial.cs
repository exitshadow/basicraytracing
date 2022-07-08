using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchMaterial : MonoBehaviour
{
    public RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        Color color = Color.white;
        Debug.DrawRay(transform.position, transform.forward * 20, color, 3);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 20)) {
            if (hit.transform.GetComponent<Renderer>() != null) {
                GetComponent<Renderer>().material = hit.transform.GetComponent<Renderer>().material;
                color = Color.blue;
            }
        }
    }
}
