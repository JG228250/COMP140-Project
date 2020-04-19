using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Uduino;

public class ReadArduinoStrings : MonoBehaviour
{
    private bool shotFired = false;

    public int sensorValueE;
    public int sensorValueA;
    private int sensorValueD;
    private int sensorValueG;

    // Start is called before the first frame update
    void Start()
    {
        UduinoManager.Instance.pinMode(2, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(3, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(4, PinMode.Input_pullup);
        UduinoManager.Instance.pinMode(5, PinMode.Input_pullup);
    }

    // Update is called once per frame
    void Update()
    {
        sensorValueE = UduinoManager.Instance.digitalRead(2);
        sensorValueA = UduinoManager.Instance.digitalRead(3);
        sensorValueD = UduinoManager.Instance.digitalRead(4);
        sensorValueG = UduinoManager.Instance.digitalRead(5);
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
