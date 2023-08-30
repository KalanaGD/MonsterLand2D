using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == ("Enemy"))
        {
            Destroy(target.gameObject);
        }
    }
}//class
