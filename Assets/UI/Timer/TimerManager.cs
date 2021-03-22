using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;
    private float record;

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        timeText.text = "Time:\n00.00.00";
        BeginTimer();
        float.TryParse(MainDependencyImpl.getInstance().GetServiceManager().GetGameService().ShowRecord(), out record);
        Debug.Log(elapsedTime + " is elaps");
    }

    public void BeginTimer()
    {
        timerGoing = true;
        elapsedTime = 0f;
        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;
        Debug.Log(elapsedTime + " is elaps2");
        if (elapsedTime > record)
        {
            MainDependencyImpl.getInstance().GetServiceManager().GetGameService().SaveRecord(elapsedTime.ToString());
            FindObjectOfType<AskMenuManager>().newRecText.SetActive(true);
        }
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time:\n" + timePlaying.ToString("mm'.'ss'.'ff");
            try
            {
                timeText.text = timePlayingStr;
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }

            yield return null;
        }
    }
}