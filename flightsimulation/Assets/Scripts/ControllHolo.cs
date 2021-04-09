using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllHolo : MonoBehaviour
{
    public GameObject terrain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = terrain.transform.rotation;
    }
}
