using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad : MonoBehaviour
{
    public void OnButtonPress(int number)
    {
        Debug.Log("The button pressed is " + number);
    }
}
