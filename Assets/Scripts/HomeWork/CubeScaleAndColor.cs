using UnityEngine;
using UnityEngine.InputSystem;

namespace HomeWork
{
    public class CubeScaleAndColor : MonoBehaviour
    {
        readonly Keyboard keyboard = Keyboard.current;

        public Material redMat;
        private Material normalMat;
        private GameObject obj = null;
        private int scaleFactor = 1;

        private void Start()
        {
            if (obj == null) obj = gameObject;
        }

        private void Update()
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                RaycastHit info;
                if (Camera.main == null) return;
                // 从屏幕当前鼠标位置发射出去一条射线
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()), out info))
                {
                    obj = info.collider.gameObject;
                    normalMat = obj.GetComponent<MeshRenderer>().material;
                    obj.GetComponent<MeshRenderer>().material = redMat;
                }
                else
                {
                    if (obj != null)
                    {
                        obj.GetComponent<MeshRenderer>().material = normalMat;
                    }

                    obj = null;
                }
            }


            if (obj != null)
            {
                if (keyboard.numpadPlusKey.wasPressedThisFrame || keyboard.equalsKey.wasPressedThisFrame)
                {
                    scaleFactor += 1;
                    obj.transform.localScale = Vector3.one * scaleFactor;
                }

                if (keyboard.numpadMinusKey.wasPressedThisFrame || keyboard.minusKey.wasPressedThisFrame)
                {
                    scaleFactor = scaleFactor < 1 ? 1 : scaleFactor -= 1;
                    obj.transform.localScale = Vector3.one * scaleFactor;
                }
            }
        }
    }
}