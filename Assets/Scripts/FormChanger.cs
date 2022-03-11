using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormChanger : MonoBehaviour
{
    [SerializeField] GameObject[] m_form;

    // Start is called before the first frame update
    void Start()
    {
        m_form[0].SetActive(true);
        m_form[1].SetActive(false);
        m_form[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Change from multi to Caliber
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_form[0].SetActive(false);
            m_form[1].SetActive(true);
            m_form[2].SetActive(false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_form[0].SetActive(false);
            m_form[1].SetActive(false);
            m_form[2].SetActive(true);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_form[0].SetActive(true);
            m_form[1].SetActive(false);
            m_form[2].SetActive(false);
        }
    }
}
