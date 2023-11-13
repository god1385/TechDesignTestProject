using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void TriggerAnimation(string animationName)
    {
        _animator.SetTrigger(animationName);
    }
}
