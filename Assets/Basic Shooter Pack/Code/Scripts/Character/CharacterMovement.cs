using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterMovement : MonoBehaviour, ICharacterMovement
{
    private CharacterData datas;
    private Rigidbody _rigidbody;
    private Animator _animator;

    public void Move(Vector3 Direction, float Speed)
    {
        Vector3 movement = Direction.normalized * Speed;
        _rigidbody.velocity = new Vector3(movement.x, _rigidbody.velocity.y, movement.z);
    }

    public void Attack(float Damage)
    {
        //ATTACK
    }

    public void SetDatas(CharacterData data)
    {
        datas = data;
        _rigidbody = datas.Rigidbody;
        _animator = datas.Animator;
    }
}
