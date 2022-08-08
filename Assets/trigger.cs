 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour
{
    public GameObject Player;


    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Battery"){
            Destroy(other.gameObject);
            ui_item.instance.CountItem();
        }
    }

    void Update(){
        if (Input.GetKeyDown("p")){ //pressing p will use the battery and put into the goggle
            ui_item.instance.RemoveCountItem();
        }
    }
}
