using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionMouse : MonoBehaviour
{

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void Mover()
    {

    }
}
