using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControll : MonoBehaviour
{
    private bool isNight = false;
    private Light light;
    private float lastAction = 0;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - lastAction) > 0.5)
        {
        if (Input.GetButton("Fire2"))
        {
            if (!isNight)
            {
                light.intensity = 0.1f;
                isNight = true;
                lastAction = Time.time;
            } else 
            {
                light.intensity = 1.0f;
                isNight = false;
                lastAction = Time.time;
            }
            
        }
        }
    }
}
