# InputSystemSample
### 启用设置

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



### 触屏输入

```csharp
Touchscreen ts = Touchscreen.current;
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
```

