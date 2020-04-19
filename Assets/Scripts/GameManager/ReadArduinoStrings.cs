using UnityEngine;
using Uduino;

public class ReadArduinoStrings : MonoBehaviour
{
    //Read potentiometer value.
    public static int potValue = 512;
    //Stores input of the four strings from vibration sensors.
    public int sensorValueE;
    public int sensorValueA;
    private int sensorValueD;
    private int sensorValueG;

    // Start is called before the first frame update
    void Start()
    {
        //Initiates pins with sensors.
        UduinoManager.Instance.pinMode(AnalogPin.A0, PinMode.Input);
        UduinoManager.Instance.pinMode(2, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(3, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(4, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(5, PinMode.Input_pullup);
    }

    // Update is called once per frame
    void Update()
    {
        //Reads values from sensors.
        potValue = UduinoManager.Instance.analogRead(AnalogPin.A0);
        sensorValueE = UduinoManager.Instance.digitalRead(2);
        sensorValueA = UduinoManager.Instance.digitalRead(3);
        sensorValueD = UduinoManager.Instance.digitalRead(4);
        sensorValueG = UduinoManager.Instance.digitalRead(5);
        //Shoots the weapon based on string input.
        if (sensorValueE == 0)
        {
            FindObjectOfType<SpeakerShooter>().RedWeapon();
        }
        if (sensorValueA == 0)
        {
            FindObjectOfType<SpeakerShooter>().GreenWeapon();
        }
        if (sensorValueD == 0)
        {
            FindObjectOfType<SpeakerShooter>().PurpleWeapon();
        }
        if (sensorValueG == 0)
        {
            FindObjectOfType<SpeakerShooter>().BlueWeapon();
        }
    }
}
