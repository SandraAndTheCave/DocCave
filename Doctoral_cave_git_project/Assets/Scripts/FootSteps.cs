using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

[RequireComponent(typeof(AudioSource))]
public class FootSteps : MonoBehaviour
{


    public SteamVR_Action_Boolean m_MovePress = null;
    [SerializeField] private AudioClip[] m_FootstepSounds;
    private AudioSource m_AudioSource;

    bool playerismoving;
    public float walkingspeed;
    void Update()
    {
        //if button pressed
        if (m_MovePress.state)
            {
                playerismoving = true;
            }

        else 
            {
                playerismoving = false;
            }
    }

    void CallFootsteps()
    {
        if (playerismoving == true)
    {
            int n = Random.Range(1, m_FootstepSounds.Length);
            m_AudioSource.clip = m_FootstepSounds[n];
            m_AudioSource.PlayOneShot(m_AudioSource.clip);
            // move picked sound to index 0 so it's not picked next time
            m_FootstepSounds[n] = m_FootstepSounds[0];
            m_FootstepSounds[0] = m_AudioSource.clip;
        }

    }
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();

        {
            InvokeRepeating("CallFootsteps", 0, walkingspeed);
        }

    }
}