using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DisplayFlightData : MonoBehaviour
{
    public AudioSource warning_sound;
    public Text textSpeed;
    public Text textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private Image image;
    private FlyJoystick flyJoystick;
    private IEnumerator coroutine;
    private bool isWarningSound = false;

    // Start is called before the first frame update
    void Start()
    {
        image = warnImage.GetComponent<Image>();
        coroutine = BlinkWarning(0.5f);
        flyJoystick = player.GetComponent<FlyJoystick>();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
       
        textHeight.text = "Alt: " + (int) player.transform.position.y + " m";
        textSpeed.text = "Speed: " + (int)(flyJoystick.speed * flyJoystick.speedAmplifier)  + " km/h";

        if (player.transform.position.y < warningHeight)
        {
            warnImage.SetActive(true);
            textHeight.color = Color.red;
            if (!isWarningSound)
            {
                warning_sound.Play();
                isWarningSound = true;
            }
            

        }else 
        {
            warnImage.SetActive(false);
            textHeight.color = Color.white;
            if (isWarningSound)
            {
                warning_sound.Stop();
                isWarningSound = false;
            }
            
        }

}

private IEnumerator BlinkWarning(float waitTime)
{
    while(true)
    {
        image.enabled = true;
        yield return new WaitForSeconds(waitTime);
        image.enabled = false;
        yield return new WaitForSeconds(waitTime);
    }
}


}

