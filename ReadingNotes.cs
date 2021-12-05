using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingNotes : MonoBehaviour {

    public GameObject Pic;
    public GameObject text;



    // Use this for initialization
    void Start () {

        Pic.SetActive(false);
        text.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Pic.SetActive(false);


        }
    }



    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "attackArea")
        {
            text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
             
                Pic.SetActive(true);

            }



        }
    }


    public void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }



}
