using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class InputTouchSample : MonoBehaviour
{
    private Touchscreen ts;

    void Start()
    {
        ts = Touchscreen.current;
        if (ts == null) return;

        // 得到手指数量
        int touchesCount = ts.touches.Count;

        // 单个手指
        var touches = ts.touches;
        TouchControl tc = touches[0];

        // 按下，抬起，长按
        if (tc.press.wasPressedThisFrame) { }
        if (tc.press.wasReleasedThisFrame) { }
        if (tc.press.isPressed) { }

        // 是否单击
        if (tc.tap.isPressed) { }

        // 连续点击次数 在某些情况下，两个手指可能交替点击，这可能会错误地记录为一个手指点击并同时移动
        var tapCount = tc.tapCount;

        // 手指位置信息
        var currentPos = tc.position.ReadValue();
        // 第一次点击位置
        var startPos = tc.startPosition.ReadValue();
        // 点击接触范围
        tc.radius.ReadValue();
        // 偏移位置 可以得到移动方向
        tc.delta.ReadValue();
        // 当前手指状态，点击或移动中
        TouchPhase tp = tc.phase.ReadValue();
    }
}