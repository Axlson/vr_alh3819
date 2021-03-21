using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 movement = new Vector3(Random.Range(-5.0f,5.0f), 0f, Random.Range(-5.0f, 5.0f));
        //rb.AddForce(movement);
    }
}
