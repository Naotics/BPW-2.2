using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{
    public GameObject UI;
    public GameObject trigger_leave;
    public GameObject trigger_drink;
    public AudioSource source;
    public AudioClip clip;
    public Animator Animator;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            UI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            source.PlayOneShot(clip);
            trigger_leave.SetActive(true);
            UI.gameObject.SetActive(false);
            GameObject.Find("NestedParent_Unpack").GetComponent<Animator>().SetTrigger("Drunk");
            Destroy(this);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            UI.gameObject.SetActive(false);
        }
    }

}
