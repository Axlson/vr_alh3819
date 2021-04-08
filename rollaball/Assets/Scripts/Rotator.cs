using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool move;
    public GameObject location1;
    public GameObject location2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform .Rotate (new Vector3 (15, 30, 45) * Time. deltaTime );
        if (move)
        {
            float step = 0.1f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, location1.transform.position, step);

            if (Vector3.Distance(transform.position, location1.transform.position) < 0.001f)
            {
                // Swap the position of the cylinder.
                GameObject a = location1;
                GameObject b = location2;
                location1 = b;
                location2 = a;
            }
        }
    }

    
}
