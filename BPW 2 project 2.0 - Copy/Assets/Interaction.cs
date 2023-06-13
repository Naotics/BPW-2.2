using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour
{
    public GameObject UI;

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
            SceneManager.LoadScene("Second Scene");
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Player")
        {
            UI.gameObject.SetActive(false);
        }
    }
}
