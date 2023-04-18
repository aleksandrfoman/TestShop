using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    private bool isRun;

    public void ActivateRun()
    {
        isRun = true;
        animator.SetBool("IsRun", isRun);
    }

    public void ActivateIdle()
    {
        isRun = false;
        animator.SetBool("IsRun", isRun);
    }
}
