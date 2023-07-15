using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public interface ICharacterMovement
{
    void Move(Vector3 Direction, float Speed);
    void Attack(float Damage);
    void SetDatas(CharacterData data);
}

public class Character : MonoBehaviour
{
    [SerializeField] protected float Health;
    [SerializeField] protected float Damage;
    [SerializeField] protected float Speed;
    
    
}