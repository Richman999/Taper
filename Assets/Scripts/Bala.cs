using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] int daño;

    [SerializeField] GameObject bala;
    private int tiempo;
    
    void Start()
    {
        
    }

    void Update()
    {
        /*tiempo++;
        if (tiempo >= 8)
        {
            Destroy(bala);
        }*/
        Destroy(this.gameObject, 8);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }

}
