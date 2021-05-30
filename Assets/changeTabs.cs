using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTabs : MonoBehaviour
{
    public GameObject dashboard;
    public GameObject timer;
    public GameObject files;
    public GameObject dashboard_under;
    public GameObject timer_under;
    public GameObject files_under;
    public GameObject cards;
    public GameObject cards_under;
    public GameObject maths;
    public GameObject maths_under;

    void everythingFalse()
    {
        dashboard.SetActive(false);
        timer.SetActive(false);
        files.SetActive(false);
        dashboard_under.SetActive(false);
        timer_under.SetActive(false);
        files_under.SetActive(false);
        cards.SetActive(false);
        cards_under.SetActive(false);
        maths.SetActive(false);
        maths_under.SetActive(false);
    }

    void open_dashboard()
    {
        everythingFalse();
        dashboard.SetActive(true);
        dashboard_under.SetActive(true);
    }

    void open_timer()
    {
        everythingFalse();
        timer.SetActive(true);
        timer_under.SetActive(true);
    }

    void open_files()
    {
        everythingFalse();
        files.SetActive(true);
        files_under.SetActive(true);
    }

    void open_cards()
    {
        everythingFalse();
        cards.SetActive(true);
        cards_under.SetActive(true);
    }

    void open_math()
    {
        everythingFalse();
        maths.SetActive(true);
        maths_under.SetActive(true);
    }
}
