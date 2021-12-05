using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanosConsole : MonoBehaviour {

    public Slider HealthBar;
    public int Bar;



    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            HealthBar.value--;

        }
    }
}
