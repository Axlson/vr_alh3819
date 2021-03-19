using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //private Vector3 target = new Vector3(0f, 0.05f, 0f);
    private Vector3 target;
    private Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        System.Random r = new System.Random();
        int xInt = r.Next(0, 5);
        int zInt = r.Next(0,5);
        target = new Vector3(transform.position.x + 1, 0.05f, transform.position.z);
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform .Rotate (new Vector3 (15, 30, 45) * Time. deltaTime );
        float step = 0.1f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,target , step);

        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            // Swap the position of the cylinder.
            Vector3 a = target;
            Vector3 b = initialPos;
           target = b;
           initialPos = a;
        }

    
    }
}
