﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

//https://www.youtube.com/watch?v=29vyEOgsW8s&list=LL&index=1&t=142s

public class audioInput : MonoBehaviour
{
    public int sentence1TotalAmount;
    public int sentence2TotalAmount;
    //public int sentence3TotalAmount;
    //public int sentence4TotalAmount;
    //public int sentence5TotalAmount;
    //public int sentence6TotalAmount;

    public int sentence1CurrentAmount;
    public int sentence2CurrentAmount;
    //public int sentence3CurrentAmount;
    //public int sentence4CurrentAmount;
    //public int sentence5CurrentAmount;
    //public int sentence6CurrentAmount;

    //public string sentence1 = "I let the dog inside";
    //public string sentence2 = "There is nothing left to say";
    //public string sentence3 = "Destroy them"; 
    //public string sentence4 = "Ex-Solider, I quit";
    //public string sentence5 = "Are you okay"; 
    //public string sentence6 = "Good morning how are you feeling today";

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> phrases = new Dictionary<string, Action>();

    // Start is called before the first frame update
    void Start()
    {

        phrases.Add("I let the dog inside", level1);
        phrases.Add("There is nothing left to say", level2);
        //phrases.Add(sentence3, level3);
        //phrases.Add(sentence4, level4);
        //phrases.Add(sentence5, level5);
        //phrases.Add(sentence6, level6);

        keywordRecognizer = new KeywordRecognizer(phrases.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += voiceConfirm;
        keywordRecognizer.Start();
    }

    private void voiceConfirm(PhraseRecognizedEventArgs speech)
    {
        Debug.Log("Success");
        phrases[speech.text].Invoke();
    }

    //--------------------------------------------------------------------------------

    private void level1()
    {
        //sentence1TotalAmount = Random.Range(1, 10);
        //sentence1CurrentAmount += 1;
        //if (sentence1CurrentAmount == sentence1TotalAmount)
        //{
            Debug.Log("success1");
        //}
    }

    private void level2()
    {
        //sentence2TotalAmount = Random.Range(1, 10);
        //sentence1CurrentAmount += 1;
        //if (sentence2CurrentAmount == sentence2TotalAmount)
        //{
            Debug.Log("success2");
        //}
    }

    //private void level3()
    //{
    //    sentence3TotalAmount = Random.Range(1, 10);
    //    sentence3CurrentAmount += 1;
    //    if (sentence3CurrentAmount == sentence3TotalAmount)
    //    {
    //        Debug.Log("success3");
    //    }
    //}

    //private void level4()
    //{
    //    sentence4TotalAmount = Random.Range(1, 10);
    //    sentence4CurrentAmount += 1;
    //    if (sentence4CurrentAmount == sentence4TotalAmount)
    //    {
    //        Debug.Log("success4");
    //    }
    //}

    //private void level5()
    //{
    //    sentence5TotalAmount = Random.Range(1, 10);
    //    sentence5CurrentAmount += 1;
    //    if (sentence5CurrentAmount == sentence5TotalAmount)
    //    {
    //        Debug.Log("success5");
    //    }
    //}

    //private void level6()
    //{
    //    sentence6TotalAmount = Random.Range(1, 10);
    //    sentence6CurrentAmount += 1;
    //    if (sentence6CurrentAmount == sentence6TotalAmount)
    //    {
    //        Debug.Log("success6");
    //    }
    //}

}