using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float hradi = 2; // base hreifinganumer fyrir spilaran
    public float hlidar = 2;
    public float hopp = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("byrja");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.UpArrow)) // afram
       {
           transform.position += transform.forward * hradi;
       }
       if(Input.GetKey(KeyCode.DownArrow)) // tilbaka = -afram * hradi
       {
           transform.position += -transform.forward * hradi;
       }
       if(Input.GetKey(KeyCode.RightArrow))  // haegri
       {
           transform.position += transform.right * hradi;
       }
       if(Input.GetKey(KeyCode.LeftArrow)) // vinstri
       {
           transform.position += -transform.right * hradi;
       }
       if(Input.GetKey(KeyCode.Space)) // upp 
       {
           transform.position += transform.up * hopp;
       }
       if(Input.GetKey("c")) // nidur
       {
           transform.position += -transform.up * hopp;
       }
    }
}
