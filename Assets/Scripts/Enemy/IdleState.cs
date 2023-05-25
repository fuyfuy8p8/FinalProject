using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator))]
public class IdleState : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private NavMeshAgent _agent;

    private int _animatorParamRun = Animator.StringToHash("Run");
    private int _animatorParamAttack = Animator.StringToHash("Attack");


    private void Update()
    {
        _animator.SetBool(_animatorParamRun, false);
        _animator.SetBool(_animatorParamAttack, false);
    }
}
