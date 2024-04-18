using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaMugControll : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject, 2);
    }
}
