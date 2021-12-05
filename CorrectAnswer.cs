using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour {


    public GameObject textcorrect;
    public GameObject ThePrize;
    public GameObject chest;
    public GameObject PuzzleCard;
    public GameObject text;


    // Use this for initialization
    public void CallCoroutine()
    {
        StartCoroutine(Correct());
        ThePrize.SetActive(true);
        chest.SetActive(false);
        PuzzleCard.SetActive(false);
        text.SetActive(false);
    }


    // Update is called once per frame
    private IEnumerator Correct()

    {
        textcorrect.SetActive(true);
        yield return new WaitForSeconds(4f);
        textcorrect.SetActive(false);
    }
}

