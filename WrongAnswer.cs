using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongAnswer : MonoBehaviour {



    public GameObject textWronng;


    // Use this for initialization
    public void CallCoroutine ()
    {
        StartCoroutine(Wrong());
    }


    // Update is called once per frame
    private IEnumerator Wrong ()

    {
        textWronng.SetActive(true);
        yield return new WaitForSeconds(4f);
        textWronng.SetActive(false);
    }
}
