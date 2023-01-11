using System;
using UnityEngine;

namespace HomeWork
{
    public class Bullet : MonoBehaviour
    {
        private void Start()
        {
            Destroy(gameObject, 2);
        }

        void Update()
        {
            transform.Translate(Vector3.forward * 20 * Time.deltaTime);
        }
    }
}