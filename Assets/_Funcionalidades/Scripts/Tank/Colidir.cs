using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colidir : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Penguin(Clone)")
        {
            Destroy(this.gameObject);
        }
    }
}
