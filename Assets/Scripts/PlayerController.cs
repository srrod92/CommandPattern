using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Movement(Vector3 direccion, int speed)
    {
        transform.position += (direccion * speed * Time.deltaTime);
    }
}
