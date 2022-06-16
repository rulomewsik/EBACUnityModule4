using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola Update");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Hola Fixed Update Cada 50 Frames");
    }

    private void LateUpdate()
    {
        Debug.LogWarning("Hola Late Update");
    }
}
