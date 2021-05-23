using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenManager : MonoBehaviour
{
    public GameObject MainPrivateScreen;
    public GameObject PTaskInputScreen;
    public GameObject PTaskCheckScreen;
    public GameObject PCheckLogScreen;
    public GameObject PChandyScreen;
    public GameObject PSettingScreen;

    public void OnOffMainPrivate()
    {
        if(MainPrivateScreen.activeSelf == true)
        {
            MainPrivateScreen.SetActive(false);
        }else{
            MainPrivateScreen.SetActive(true);
            PTaskInputScreen.SetActive(false);
            PTaskCheckScreen.SetActive(false);
            PCheckLogScreen.SetActive(false);
            PChandyScreen.SetActive(false);
            PSettingScreen.SetActive(false);
        }
    }

    public void OnOffTaskInput()
    {
        Debug.Log("Task Input");
        if(PTaskInputScreen.activeSelf == true)
        {
            PTaskInputScreen.SetActive(false);
        }else{
            PTaskInputScreen.SetActive(true);
            PTaskCheckScreen.SetActive(false);
            PCheckLogScreen.SetActive(false);
            PChandyScreen.SetActive(false);
            PSettingScreen.SetActive(false);
        }
    }

    public void OnOffPTaskCheck()
    {
        if(PTaskCheckScreen.activeSelf == true)
        {
            PTaskCheckScreen.SetActive(false);
        }else{
            PTaskCheckScreen.SetActive(true);
            PTaskInputScreen.SetActive(false);
            PCheckLogScreen.SetActive(false);
            PChandyScreen.SetActive(false);
            PSettingScreen.SetActive(false);
        }
    }

    public void OnOffPCheckLog()
    {
        if(PCheckLogScreen.activeSelf == true)
        {
            PCheckLogScreen.SetActive(false);
        }else{
            PCheckLogScreen.SetActive(true);
            PTaskInputScreen.SetActive(false);
            PTaskCheckScreen.SetActive(false);
            PChandyScreen.SetActive(false);
            PSettingScreen.SetActive(false);
        }
    }

    public void OnOffPChandy()
    {
        if(PChandyScreen.activeSelf == true)
        {
            PChandyScreen.SetActive(false);
        }else{
            PChandyScreen.SetActive(true);
            PTaskInputScreen.SetActive(false);
            PTaskCheckScreen.SetActive(false);
            PCheckLogScreen.SetActive(false);
            PSettingScreen.SetActive(false);
        }
    }

    public void OnOffPSetting()
    {
        if(PSettingScreen.activeSelf == true)
        {
            PSettingScreen.SetActive(false);
        }else{
            PSettingScreen.SetActive(true);
            PTaskInputScreen.SetActive(false);
            PTaskCheckScreen.SetActive(false);
            PCheckLogScreen.SetActive(false);
            PChandyScreen.SetActive(false);
        }
    }

    void Start()
    {
        PTaskInputScreen.SetActive(false);
        PTaskCheckScreen.SetActive(false);
        PCheckLogScreen.SetActive(false);
        PChandyScreen.SetActive(false);
        PSettingScreen.SetActive(false);
    }



}
