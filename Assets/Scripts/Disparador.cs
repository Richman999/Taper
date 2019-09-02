using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    [SerializeField] GameObject mouse;
    [SerializeField] Rigidbody2D rbBala;
    [SerializeField] Transform gun;
    [SerializeField] int force;
    [SerializeField] int time;
    Vector3 direccion;
    Vector3 direccion2;
    private int tiempo;
    void Start()
    {

    }

    
    void Update()
    {
        direccion2 = (mouse.transform.position - transform.position);
        direccion2 = direccion2.normalized;

        tiempo++;

        if (tiempo >= time)
        {
            Shoot();
            tiempo = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }    
    }

    private void Shoot()
    {
        Rigidbody2D rigidbody = Instantiate(rbBala, gun.position, transform.rotation);
        rigidbody.AddForce(direccion2 * force);
    }
}
