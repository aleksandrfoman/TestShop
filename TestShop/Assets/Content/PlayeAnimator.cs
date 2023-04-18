using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    public void ActivateRun()
    {
        animator.SetLayerWeight(1, 1);
        animator.SetLayerWeight(0, 0);
    }

    public void ActivateIdle()
    {
        animator.SetLayerWeight(0, 1);
        animator.SetLayerWeight(1, 0);
    }
}
