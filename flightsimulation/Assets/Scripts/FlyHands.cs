using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyHands : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;
    private float inputPitch;
    private float inputYawn;
    private float inputRoll;
    public GameObject spotLight;
    private Vector3 forward = new Vector3(1,0,0);
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputPitch = Input.GetAxis("Pitch");
        inputYawn = Input.GetAxis("Yawn");
        inputRoll = Input.GetAxis("Roll");
        speed = -Input.GetAxis("Throttle");
        Vector3 rotVec = new Vector3(inputRoll * Time.deltaTime * rotationSpeed, inputYawn * Time.deltaTime * rotationSpeed, inputPitch * Time.deltaTime * rotationSpeed);
        
        this.transform.Rotate(rotVec);
        this.transform.Translate (forward * speed * speedAmplifier * Time.deltaTime);

        if (Input.GetButton("Fire1"))
        {
            spotLight.SetActive(true);
        } else{
            spotLight.SetActive(false);
        }
        
    }
}
