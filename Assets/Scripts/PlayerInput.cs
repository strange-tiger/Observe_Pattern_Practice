using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInput : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public bool Attack { get; private set; }

    void FixedUpdate()
    {
        X = Input.GetAxis("Horizontal");    // 이동
        Y = Input.GetAxis("Vertical");      // 회전
        Attack = Input.GetKeyDown(KeyCode.Space);
    }
}