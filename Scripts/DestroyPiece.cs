using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPiece : MonoBehaviour
{
    // Start is called before the first frame update
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > (target.position.y + 0.8f))
        {
           var allcollider = Physics.OverlapSphere(transform.position, 1);
            foreach (var item in allcollider)
            {
                var rb = item.GetComponent<Rigidbody>();
                if (rb != null && item.gameObject.tag == "Coin"||  item.gameObject.tag=="Finish")
                {
                    rb.useGravity = true;
                    rb.isKinematic = false;
                    rb.AddExplosionForce(60f, item.gameObject.transform.position, 30);
                    item.GetComponent<MeshCollider>().enabled = false;
                }
               
            }
        }
    }

}
