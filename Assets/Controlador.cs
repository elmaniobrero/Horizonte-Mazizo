using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public float velocidad = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transforme.position += Vector3.up * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transforme.position += Vector3.left * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transforme.position += Vector3.down * velocidad * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transforme.position += Vector3.right * velocidad * Time.deltaTime;
        }
    }
}
