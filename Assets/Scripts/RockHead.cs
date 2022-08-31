using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHead : MonoBehaviour
{
    public float fallingTime;
    private BoxCollider2D boxColl;
    private FixedJoint2D fix;

    // Start is called before the first frame update
    void Start()
    {
        fix = GetComponent<FixedJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Invoke("Falling", fallingTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 9)
        {
            Destroy(gameObject);
        }
    }

    void Falling()
    {
        fix.enabled = false;
        boxColl.isTrigger = true;
    }
}
