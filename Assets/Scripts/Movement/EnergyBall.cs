using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBall : MonoBehaviour
{
    private float velocidadX = 5;
    private float velocidadY = -5.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            velocidadX * Time.deltaTime,
            velocidadY * Time.deltaTime,
            0);
        if ((transform.position.x < -5.5) 
            || (transform.position.x > 5.5))
            velocidadX = -velocidadX;
        if ((transform.position.y < -3.5) 
            || (transform.position.y > 3.5))
            velocidadY = -velocidadY;
    }
}
