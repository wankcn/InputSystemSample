using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GenerateCsharpCode : MonoBehaviour
{
    private GenrateTest input;

    private void Start()
    {
        // 1。创建生成代码的对象
        input = new GenrateTest();
        // 2。激活输入
        input.Enable();
        // 3. 事件监听
        input.Action1.Fire.performed += OnFire;
        input.Action2.Jump.performed += OnJump;
    }

    private void Update()
    {
        print(input.Action1.Move.ReadValue<Vector2>());
    }

    private void OnFire(InputAction.CallbackContext context)
    {
        print("开火");
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        print("跳跃");
    }
}