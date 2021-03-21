using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //Atributes
    public bool keyboard;
    public float speed;
    public GameObject scoreboard;
    private Rigidbody rb;
    private bool lost = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (keyboard)
        {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical); 
        rb.AddForce(movement * speed);
        }


    }

    void OnTriggerEnter (Collider other)
    {
        if (!lost)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                scoreboard.GetComponent<ScoreControl>().incrementScore();

            }

            if (other.gameObject.CompareTag("enemy"))
            {
                scoreboard.GetComponent<ScoreControl>().displayLost();
                lost = true;
            }
        }
    }
}
