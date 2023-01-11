using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMouseSamole : MonoBehaviour
{
    readonly Mouse mouse = Mouse.current;

    // Start is called before the first frame update
    void Start()
    {
        //鼠标左键
        //mouse.leftButton
        //鼠标右键
        //mouse.rightButton
        //鼠标中键
        //mouse.middleButton
        //鼠标 向前向后键
        //mouse.forwardButton;
        //mouse.backButton;

        // 获取当前鼠标位置
        mouse.position.ReadValue();
        // 得到鼠标两帧之间的一个偏移向量 
        mouse.delta.ReadValue();
        // 鼠标中间 滚轮的方向向量
        mouse.scroll.ReadValue();
    }


    void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
            print("鼠标左键按下");
        }

        //抬起
        if (mouse.leftButton.wasReleasedThisFrame)
        {
            print("鼠标左键抬起");
        }

        //长按
        if (mouse.rightButton.isPressed)
        {
            print("鼠标右键长按");
        }
        
    }
}