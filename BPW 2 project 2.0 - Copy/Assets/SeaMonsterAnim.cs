using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class SeaMonsterAnim : MonoBehaviour
{
    public PlayableDirector timeline;

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            timeline.Play();
        }
    }
}
