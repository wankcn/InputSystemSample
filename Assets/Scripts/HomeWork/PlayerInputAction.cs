using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HomeWork
{
    public class PlayerInputAction : MonoBehaviour
    {
        [Header("移动控制")] public InputAction move;
        [Header("跳跃控制")] public InputAction jump;
        [Header("开火控制")] public InputAction fire;

        public GameObject bullet;
        private Rigidbody rb;
        private Vector3 dir;
        public float force = 1.0f;

        private void Start()
        {
            rb = this.GetComponent<Rigidbody>();
            move.Enable();
            jump.Enable();
            fire.Enable();
            jump.performed += Jump;
            fire.performed += Fire;
        }


        private void Update()
        {
            var pos = move.ReadValue<Vector2>();
            dir = new Vector3(pos.x, 0, pos.y);
            rb.AddForce(dir);
        }

        private void Jump(InputAction.CallbackContext context)
        {
            rb.AddForce(Vector3.up * 200);
        }

        private void Fire(InputAction.CallbackContext context)
        {
            if (Camera.main != null)
            {
                var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
                if (Physics.Raycast(ray, out var info))
                {
                    // 获得单位向量
                    Vector3 point = info.point;
                    var position = transform.position;
                    point.y = position.y;
                    Vector3 direction = (point - position).normalized;

                    // 创建子弹
                    Instantiate(bullet, this.transform.position, Quaternion.LookRotation(direction));
                }
            }
        }
    }
}