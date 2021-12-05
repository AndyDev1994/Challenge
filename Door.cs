using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public AnimationClip anim;

    public GameObject Key;
    public bool DOOR = false;

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R) && DOOR == true && Key.activeSelf == false)
        {
            GameObject.Find("DOOR").GetComponent<Animation>().Play("DoorOpen");

        }

    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
           DOOR = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
           DOOR = false;
        }
    }

}
