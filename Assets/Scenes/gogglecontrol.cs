using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gogglecontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
void onTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { Debug.Log("detected"); }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
