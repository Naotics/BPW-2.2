using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShaderAnimations : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        GameObject.Find("Water").GetComponent<Animator>().SetTrigger("Color Changed");
        GameObject.Find("Water").GetComponent<Animator>().SetTrigger("Waves");
    }
}
