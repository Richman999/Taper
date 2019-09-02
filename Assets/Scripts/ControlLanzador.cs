using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLanzador : MonoBehaviour
{
    [SerializeField] Transform pivot;
    [SerializeField] Transform mouse;
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.forward, 20 * Time.deltaTime);
    }
}
