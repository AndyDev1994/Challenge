using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public GameObject TheKey;
    private bool playerNextToKey = false;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R) && playerNextToKey == true)
        {
            TheKey.SetActive(false);
        }

     }


    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            playerNextToKey = true;
            
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            playerNextToKey = false;
        }
    }
}
