using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesScript : MonoBehaviour
{
    public GameObject notesSet0;
    public GameObject notesSet1;
    public GameObject notesSet2;
    public GameObject notesSet3;
    public GameObject notesSet4;
    public GameObject notesSet5;
    public GameObject notesSet6;
    public GameObject notesSet7;
    public GameObject notesSet8;

    // Update is called once per frame
    void endEverything()
    {
        notesSet0.SetActive(false);
        notesSet1.SetActive(false);
        notesSet2.SetActive(false);
        notesSet3.SetActive(false);
        notesSet4.SetActive(false);
        notesSet5.SetActive(false);
        notesSet6.SetActive(false);
        notesSet7.SetActive(false);
        notesSet8.SetActive(false);
    }

    void open0()
    {
        endEverything();
        notesSet0.SetActive(true);
    }

    void open1()
    {
        endEverything();
        notesSet1.SetActive(true);
    }
    
    void open2()
    {
        endEverything();
        notesSet2.SetActive(true);
    }

    void open3()
    {
        endEverything();
        notesSet3.SetActive(true);
    }
    
    void open4()
    {
        endEverything();
        notesSet4.SetActive(true);
    }

    void open5()
    {
        endEverything();
        notesSet5.SetActive(true);
    }
    
    void open6()
    {
        endEverything();
        notesSet6.SetActive(true);
    }

    void open7()
    {
        endEverything();
        notesSet7.SetActive(true);
    }
    
    void open8()
    {
        endEverything();
        notesSet8.SetActive(true);
    }
}
