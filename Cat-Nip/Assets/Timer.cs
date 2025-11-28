using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timerText;
    float timeleft = 200;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime; 
        timerText.text = timeleft.ToString("F2"); 
    }
}
