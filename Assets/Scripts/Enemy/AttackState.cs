using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackState : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _delay;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private CapsuleCollider _attackTrigger;

    private int _animatorParamAttack = Animator.StringToHash("Attack");

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.SetBool(_animatorParamAttack, true);
    }

    private void OnDisable()
    {
        _animator.SetBool(_animatorParamAttack, false);
    }

    private void OnAttack()
    {
        _attackTrigger.enabled = true;
    }
}
