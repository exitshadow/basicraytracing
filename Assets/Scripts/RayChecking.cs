using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayChecking : MonoBehaviour
{
    private Color color = Color.red;
    public RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 100, color, 3);
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            Debug.Log($"hit {hit.transform.name}.");
            hit.transform.position += transform.forward * Time.deltaTime * 3f;
            color = Color.green;
        } else color = Color.red;
    }
}
