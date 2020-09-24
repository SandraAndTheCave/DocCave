using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CallMixerSanpshots : MonoBehaviour
{
    public AudioMixerSnapshot isoLuola;
    public AudioMixerSnapshot corridor;
    public int m_TransitionIn;
    public int m_TransitionOut;

    // Start is called before the first frame update
    void Start()
    {
        m_TransitionIn = 2;
        m_TransitionOut = 2;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            corridor.TransitionTo(m_TransitionIn);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isoLuola.TransitionTo(m_TransitionOut);
        }
    }
}
