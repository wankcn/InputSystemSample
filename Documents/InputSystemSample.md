### 修改应用

File ->Build Setting -> Player Setting -> Other ->Active Input Handing

可以同时启用或只启用一种，每次启用后会重启Unity



### 键盘输入

```csharp
Keyboard keyBoard = Keyboard.current;
void Update()
{
    // 单个案件按下，抬起，长按
    if (keyBoard.aKey.wasPressedThisFrame) { }
    if (keyBoard.aKey.wasReleasedThisFrame) { }
    if (keyBoard.aKey.isPressed) { }

    // 任意键
    if (keyBoard.anyKey.wasPressedThisFrame) { }

    // 事件监听
    keyBoard.onTextInput += (c) => { print("通过lambda表达式" + c); };
    keyBoard.onTextInput += TextInput;
    keyBoard.onTextInput -= TextInput;
}

private void TextInput(char c) { print("通过函数进行事件监听" + c); }
```



### 鼠标输入

```csharp
// 按下 抬起 长按
if (Mouse.current.leftButton.wasPressedThisFrame){print("鼠标左键按下");}
if (Mouse.current.leftButton.wasReleasedThisFrame){print("鼠标左键抬起");}
if (Mouse.current.rightButton.isPressed){print("鼠标右键长按");}
```

```csharp
// 获取当前鼠标位置
mouse.position.ReadValue();
// 得到鼠标两帧之间的一个偏移向量 （获得鼠标移动方向）
mouse.delta.ReadValue();
// 鼠标中间 滚轮的方向向量
mouse.scroll.ReadValue();
```

