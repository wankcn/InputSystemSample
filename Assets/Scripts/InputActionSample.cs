using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActionSample : MonoBehaviour
{
    public InputAction move;
    public InputAction run;
    public InputAction axis;
    public InputAction vector2D;
    public InputAction btnOne;


    private void Start()
    {
        // 启用操作
        move.Enable();
        axis.Enable();
        vector2D.Enable();
        btnOne.Enable();
        // 操作监听
        move.started += Started;
        move.performed += Performed;
        move.canceled += Canceled;
        btnOne.performed += (context) => { print("组合键触发"); };
    }


    private void Started(InputAction.CallbackContext context)
    {
        print("开始事件调用");
    }

    private void Performed(InputAction.CallbackContext context)
    {
        print("触发事件调用");
        // 状态信息 Disabled,Waiting,Started,Performed,Canceled
        if (context.phase == InputActionPhase.Disabled)
        {
        }

        // 行为信息
        var action = context.action;
        // 控件信息
        var control = context.control;
        // 获取值
        // context.ReadValue<float>;
        // 持续时间
        var durTime = context.duration;
        // 开始时间
        var startTime = context.startTime;
    }

    private void Canceled(InputAction.CallbackContext context)
    {
        print("结束事件调用");
    }


    private void Update()
    {
        // print(axis.ReadValue<float>());
        print(vector2D.ReadValue<Vector2>());
    }
}