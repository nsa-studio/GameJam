using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSoundZone : MonoBehaviour
{
    [SerializeField] private AudioSource _stepSound;

    void Start()
    {
        _stepSound = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        _stepSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        _stepSound.Stop();

    }
}
