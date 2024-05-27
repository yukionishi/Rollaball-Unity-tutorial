using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Sphere Enter collider:" + collision.gameObject.name);
        return;

    }
}
