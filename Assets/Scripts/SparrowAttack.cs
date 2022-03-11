using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparrowAttack : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public float m_Cooldown = 2f;
    public static int m_ClickedTimes = 0;
    private float NextAttackTime = 0f;
    float maxComboDelayTime = 1f;
    float LastClickedTime = 0f;

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && animator.GetCurrentAnimatorStateInfo(0).IsName("Sword And Shield Slash 1"))
        {
            animator.SetBool("Attack1", false);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && animator.GetCurrentAnimatorStateInfo(0).IsName("Sword And Shield Slash"))
        {
            animator.SetBool("Attack2", false);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && animator.GetCurrentAnimatorStateInfo(0).IsName("Upward Thrust"))
        {
            animator.SetBool("Attack3", false);
            m_ClickedTimes = 0;
        }

        if (Time.time - LastClickedTime > maxComboDelayTime)
        {
            m_ClickedTimes = 0;
        }
        if (Time.time > NextAttackTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }
        }
    }

    void OnClick()
    {
        LastClickedTime = Time.time;
        m_ClickedTimes++;
        if (m_ClickedTimes == 1)
        {
            animator.SetBool("Attack1", true);
        }
        m_ClickedTimes = Mathf.Clamp(m_ClickedTimes, 0, 3);

        if (m_ClickedTimes >= 2 && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && animator.GetCurrentAnimatorStateInfo(0).IsName("Sword And Shield Slash 1"))
        {
            animator.SetBool("Attack1", false);
            animator.SetBool("Attack2", true);
        }
        if (m_ClickedTimes >= 3 && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.7f && animator.GetCurrentAnimatorStateInfo(0).IsName("Sword And Shield Slash"))
        {
            animator.SetBool("Attack2", false);
            animator.SetBool("Attack3", true);
        }
    }
}
