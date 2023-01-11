using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputKeyBoardSample : MonoBehaviour
{
    readonly Keyboard keyboard = Keyboard.current;

    void Update()
    {
        if (keyboard.aKey.wasPressedThisFrame)
        {
            print("PressDown A Key");
        }

        if (keyboard.sKey.wasReleasedThisFrame)
        {
            print("PressUp Space Key");
        }

        if (keyboard.dKey.isPressed)
        {
            print("Press D Key");
        }
    }
}