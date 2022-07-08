using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchMaterial : MonoBehaviour
{
    public RaycastHit hit;
    Material baseMat;

    void Start() {
        baseMat = GetComponent<Renderer>().material;
    }
    void Update()
    {
        Color color = Color.white;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 20)) {
            if (hit.transform.GetComponent<Renderer>() != null) {
                GetComponent<Renderer>().material = hit.transform.GetComponent<Renderer>().material;
                color = hit.transform.GetComponent<Renderer>().material.color;
            }
        } else {
            GetComponent<Renderer>().material = baseMat;
        }
        Debug.DrawRay(transform.position, transform.forward * 20, color, 3);
    }
}
