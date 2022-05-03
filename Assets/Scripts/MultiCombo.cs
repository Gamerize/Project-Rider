using UnityEngine;
using UnityEngine.InputSystem;

public class MultiCombo : MonoBehaviour
{
    [SerializeField]
    private Animator multiAnimator;
    [SerializeField]
    private Transform Player;

    [SerializeField]
    private InputActionReference AttackControls;
    [SerializeField]
    private InputActionReference FinisherControls;

    bool m_CanCombo;
    public int m_AttackCombo;  

    // Start is called before the first frame update
    void Start()
    {
        multiAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        AttackControls.action.Enable();
        FinisherControls.action.Enable();
    }

    private void OnDisable()
    {
        AttackControls.action.Disable();
        FinisherControls.action.Disable();
    }

    public void CanCombo()
    {
        m_CanCombo = true;
    }

    public void NextAttack()
    {
        if(m_AttackCombo == 2)
        {
            Debug.Log("2nd attack");
            multiAnimator.Play("2nd Punch");
        }
        if(m_AttackCombo == 3)
        {
            Debug.Log("final attack");
            multiAnimator.Play("Finish Kick");
        }
    }

    public void ResetCombo()
    {
        m_CanCombo = false;
        m_AttackCombo = 0;
    }
    
    void Attack()
    {
        if(m_AttackCombo == 0)
        {
            Debug.Log("1st attack");
            multiAnimator.Play("1st Punch");
            m_AttackCombo = 1;
            return;
        }
        if(m_AttackCombo != 0)
        {
            if(m_CanCombo)
            {
                m_CanCombo = false;
                m_AttackCombo += 1;
            }
        }
    }

    void Finisher()
    {
        multiAnimator.Play("Warming Up");
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Attack();
        }
        if(Input.GetKey("q"))
        {
            Finisher();
        }
    }
}
