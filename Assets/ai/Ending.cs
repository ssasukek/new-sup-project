using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            SceneManager.LoadScene("Ending");
            Cursor.visible = true;
        }
    }

}
