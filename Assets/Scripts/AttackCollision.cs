using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackCollision : MonoBehaviour
{
    public TextMeshProUGUI m_HitMessage;

    [SerializeField]
    public AudioManager AudioManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemyHitBox")
        {
            m_HitMessage.gameObject.SetActive(true);
            AudioManager.playAudio("Hit");
        }
    }
}
