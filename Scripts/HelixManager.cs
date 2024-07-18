using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixManager : MonoBehaviour
{
    public GameObject [] helixPiece;
   
    // Start is called before the first frame update
    void Start()
    {
        

        float offset = 2f;
        Vector3 startpos = transform.position;
        startpos.y = 14;

        for(int i= 0; i<=15;i++)
        {
            var rotate = Random.Range(0, 360);
            var piece = helixPiece[Random.Range(0, helixPiece.Length)];
                var helixx = Instantiate(piece, startpos, Quaternion.Euler(0, rotate, 0));
            helixx.transform.parent = transform;
            startpos.y -= offset;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
