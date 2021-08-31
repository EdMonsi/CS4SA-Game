using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Debug.Log("Time to respawn!");
        collider2D.transform.position = new Vector3(0,0,0);
    }
}
