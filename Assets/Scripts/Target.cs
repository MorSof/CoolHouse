using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    

    [SerializeField] Transform[] pos = null;

    private void OnTriggerEnter(Collider other)
    {
        print("im here");

        PlayerMotion playerMotion = other.GetComponent<PlayerMotion>();

        if (playerMotion == null)
        {
            print("im null");
            return;
        }

        
        Vector3 newPos = pos[Random.Range(0, pos.Length - 1)].position;

        while (newPos.x  == transform.position.x && newPos.z == transform.position.z)
        {
            newPos = pos[Random.Range(0, pos.Length - 1)].position;
            print("im in while" + newPos);
        }

        print("my old pos is " + transform.position + "my new pos is " + newPos);
        transform.position = newPos;
      


        playerMotion.SetTarget(transform);

    }
}
