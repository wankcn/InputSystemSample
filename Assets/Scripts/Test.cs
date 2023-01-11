using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    readonly Keyboard keyBoard = Keyboard.current;

    void Update()
    {
        // 单个案件按下，抬起，长按
        if (keyBoard.aKey.wasPressedThisFrame)
        {
        }

        if (keyBoard.aKey.wasReleasedThisFrame)
        {
        }

        if (keyBoard.aKey.isPressed)
        {
        }

        // 任意键
        if (keyBoard.anyKey.wasPressedThisFrame)
        {
        }

        // 事件监听
        keyBoard.onTextInput += (c) => { print("通过lambda表达式" + c); };
        keyBoard.onTextInput += TextInput;
        keyBoard.onTextInput -= TextInput;
    }

    private void TextInput(char c)
    {
        print("通过函数进行事件监听" + c);
    }
}