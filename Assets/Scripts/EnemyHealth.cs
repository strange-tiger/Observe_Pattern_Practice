using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Hp = 100;
    public event Action<Transform> OnTakenDamage;
    public bool IsDead { get; private set; }

    public void TakeDamage(int damage)
    {
        Hp -= damage;

        OnTakenDamage?.Invoke(transform); // 주변 객체한테 알림.

        Debug.Log($"{gameObject} : 으앙 나 데미지 입음. [{damage}]");

        if (Hp <= 0)
        {
            IsDead = true;
            gameObject.SetActive(false);

            Debug.Log($"{gameObject} : 으앙 쥬금");
        }

        //EnemyMovement move;
        //move.MoveTo();
    }
}
