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

    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        timeText.text = "Time:\n00:00.00";
        BeginTimer();
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
        MainDependencyImpl.getInstance().GetServiceManager().GetGameService().SaveRecord(timePlaying.);
    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time:\n" + timePlaying.ToString("mm'.'ss");
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