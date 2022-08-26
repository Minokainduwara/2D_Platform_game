using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain_Renderer : MonoBehaviour
{
    LineRenderer line;
    public Transform entryPoint;
    public Transform existpoint;
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(1, entryPoint.position);
        line.SetPosition(0, existpoint.position);
    }
}
