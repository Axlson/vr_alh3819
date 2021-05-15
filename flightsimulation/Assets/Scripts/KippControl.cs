using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KippControl : MonoBehaviour
{
    public GameObject target;
    public GameObject pivot;
    private bool isPressed = false;
    public AudioClip click;
    private float lastAction = 0;
    private Vector3 pos1 = new Vector3(30,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // Bei Berührung des Kippschalters wird dieser automatisch in die jeweils andere Schalterstellung bewegt
    void OnTriggerEnter(Collider other)
    {
        if ((Time.time - lastAction) > 0.5)
        {
        if (!isPressed)
        {
            pivot.transform.rotation =  Quaternion.Euler(-30, 0, 0);
            target.SetActive(false);
            isPressed = true;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
            lastAction = Time.time;
        } else 
        {
            pivot.transform.rotation =  Quaternion.Euler(30, 0, 0);
            target.SetActive(true);
            isPressed = false;
            AudioSource.PlayClipAtPoint(click, transform.position, 1);
            lastAction = Time.time;
        }
        }
        
    }
}
