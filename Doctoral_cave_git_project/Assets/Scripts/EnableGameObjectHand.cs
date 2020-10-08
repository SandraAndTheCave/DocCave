using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObjectHand : MonoBehaviour

{
    public GameObject rightHand;
    public float seconds = 14f;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
    }

    private IEnumerator ActivationRoutine()
    {
        //Wait for secs.
        yield return new WaitForSeconds(seconds);

        //Turn My game object that is set to false(off) to True(on).
        rightHand.SetActive(true);

    }
}
