using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //private Vector3 target = new Vector3(0f, 0.05f, 0f);
    public Vector3 pos1;
    public Vector3 pos2;
    public bool move;
    public GameObject board;
    private Vector3 offset1;
    private Vector3 offset2;
    // Start is called before the first frame update
    void Start()
    {
        
        offset1 = pos1 - board.transform.position;
        offset2 = pos2 - board.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        pos1 = board.transform.position + offset1;
        pos2 = board.transform.position + offset2;
        transform .Rotate (new Vector3 (15, 30, 45) * Time. deltaTime );
        if (move)
        {
            float step = 0.1f * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pos1, step);

            if (Vector3.Distance(transform.position, pos1) < 0.001f)
            {
                // Swap the position of the cylinder.
                Vector3 a = pos1;
                Vector3 b = pos2;
                pos1 = b;
                pos2 = a;
            }
        }
    }

    
}
