using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputGamepadSample : MonoBehaviour
{
    void Start()
    {
        Gamepad gamePad = Gamepad.current;
        if (gamePad == null) return;

        // 左摇杆
        gamePad.leftStick.ReadValue();
        gamePad.rightStick.ReadValue();

        // 检测摇杆按下 抬起 长按
        bool isPressed = gamePad.leftStickButton.wasPressedThisFrame;
        bool isRelease = gamePad.leftStickButton.wasReleasedThisFrame;
        bool isPress = gamePad.leftStickButton.isPressed;

        // 左右遥感
        var lf = gamePad.leftStickButton;
        var rf = gamePad.rightStickButton;

        // 手柄方向键 left,right,up,down
        var l = gamePad.dpad.left;
        var r = gamePad.dpad.right;
        var u = gamePad.dpad.up;
        var d = gamePad.dpad.down;

        // 右侧四个按钮，东南西北 
        var y = gamePad.buttonNorth;
        var A = gamePad.buttonSouth;
        var X = gamePad.buttonWest;
        var B = gamePad.buttonEast;

        // 手柄中央按键 开始和选择
        var start = gamePad.startButton;
        var select = gamePad.selectButton;

        // 手柄肩部按键
        var lShoulder = gamePad.leftShoulder;
        var lTrigger = gamePad.leftTrigger;
    }
}