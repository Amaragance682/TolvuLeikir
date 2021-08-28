using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollower : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; // distance fra object
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+offset; // tekur stodu + vector offset
        
    }
}
