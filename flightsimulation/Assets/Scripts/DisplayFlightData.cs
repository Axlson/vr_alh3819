using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayFlightData : MonoBehaviour
{
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    private IEnumerator coroutine;
    private bool showWarn;
    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        textHeight.text = "Alt: " + (int) player.transform.position.y + " m";
        textSpeed.text = "Speed: " + (int)(flyJoystick.speed * flyJoystick.speedAmplifier)  + " km/h";

        if (player.transform.position.y < warningHeight)
        {
            warnImage.SetActive(true);
        }else 
        {
            warnImage.SetActive(false);
        }
        //StartCoroutine("BlinkWarning", 5.0f);

        
 

}

private IEnumerator BlinkWarning(float waitTime)
{
    while(showWarn)
    {
        warnImage.SetActive(true);
        Debug.Log("Entered BlinkWarning");
        yield return new WaitForSeconds(waitTime);
        warnImage.SetActive(false);
        yield return new WaitForSeconds(waitTime);
    }
}


    }

