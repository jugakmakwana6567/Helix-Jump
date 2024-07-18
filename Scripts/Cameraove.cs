using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraove : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    Vector3 lastpos;

    private void Awake()
    {
        offset = transform.position - target.position;
        lastpos = target.position + offset;
    }

    private void Update()
    {
        var pos = transform.position;
        pos.y = Mathf.Min(target.position.y + offset.y, lastpos.y);
        lastpos = pos;
        transform.position = pos;

    }
}
