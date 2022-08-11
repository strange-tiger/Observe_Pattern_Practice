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

        OnTakenDamage?.Invoke(transform); // �ֺ� ��ü���� �˸�.

        Debug.Log($"{gameObject} : ���� �� ������ ����. [{damage}]");

        if (Hp <= 0)
        {
            IsDead = true;
            gameObject.SetActive(false);

            Debug.Log($"{gameObject} : ���� ���");
        }

        //EnemyMovement move;
        //move.MoveTo();
    }
}
