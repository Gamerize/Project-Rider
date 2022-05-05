using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameObject : MonoBehaviour
{
    public float m_WaitingTime;

    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Disable", m_WaitingTime);
    }

    void Disable()
    {
        gameObject.SetActive(false);
    }
}
