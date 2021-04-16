using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    private int speed = 30;
    private Vector3 forward = new Vector3(1,0,0);
    private Vector3 back = new Vector3(-1,0,0);
    private Vector3 left = new Vector3(0,-3,0);
    private Vector3 right = new Vector3(0,3,0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate (forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate (left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate (back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate (right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Translate (Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Translate (Vector3.up * speed * Time.deltaTime);
        }
    }
}
