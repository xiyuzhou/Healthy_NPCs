using System;
using System.Collections;
using UnityEngine;

public class Client : MonoBehaviour
{
    public GameObject npc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            npc.GetComponent<NPC>().TakeDamage(5);
        }
    }
}
