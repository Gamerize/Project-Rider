using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class FormChanger : MonoBehaviour
{
    [SerializeField] GameObject[] m_form;
    public TextMeshProUGUI m_FormText;

    [SerializeField]
    private InputActionReference ChangeMultiControls;
    [SerializeField]
    private InputActionReference ChangeCaliberControls;
    [SerializeField]
    private InputActionReference ChangeSparrowControls;

    private void OnEnable()
    {
        ChangeMultiControls.action.Enable();
        ChangeCaliberControls.action.Enable();
        ChangeSparrowControls.action.Enable();
    }

    private void OnDisable()
    {
        ChangeMultiControls.action.Disable();
        ChangeCaliberControls.action.Disable();
        ChangeSparrowControls.action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_form[0].SetActive(true);
        m_form[1].SetActive(false);
        m_form[2].SetActive(false);
        m_FormText.text = "Multi Form";
    }

    // Update is called once per frame
    void Update()
    {
        //Change from multi to Caliber
        if (ChangeCaliberControls.action.triggered)
        {
            m_form[0].SetActive(false);
            m_form[1].SetActive(true);
            m_form[2].SetActive(false);
            m_FormText.text = "Caliber Form";
        }
        if (ChangeSparrowControls.action.triggered)
        {
            m_form[0].SetActive(false);
            m_form[1].SetActive(false);
            m_form[2].SetActive(true);
            m_FormText.text = "Sparrow Form";
        }
        if (ChangeMultiControls.action.triggered)
        {
            m_form[0].SetActive(true);
            m_form[1].SetActive(false);
            m_form[2].SetActive(false);
            m_FormText.text = "Multi Form";
        }
    }
}
