using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{

    [SerializeField] GameObject door;
         

    private void OnTriggerEnter(Collider other)
    {
        door.GetComponent<Animator>().SetBool("doorOpen", true);
    }

    private void OnTriggerExit(Collider other)
    {
        door.GetComponent<Animator>().SetBool("doorOpen", false);

    }
}
