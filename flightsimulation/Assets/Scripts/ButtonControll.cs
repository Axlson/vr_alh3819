using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    private bool isPressed = false;
    public AudioClip click;
    private float lastAction = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if ((Time.time - lastAction) > 0.5)
        {
        if (!isPressed)
        {
            this.transform.position = this.transform.position - (transform.up * 0.015f);
            target.SetActive(false);
            isPressed = true;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
            lastAction = Time.time;
        } else 
        {
            this.transform.position = this.transform.position + (transform.up * 0.015f);
            target.SetActive(true);
            isPressed = false;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
            lastAction = Time.time;
        }
        }
        
    }
}
