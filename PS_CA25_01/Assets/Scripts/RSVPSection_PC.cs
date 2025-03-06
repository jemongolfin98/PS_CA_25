using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RSVPSection_PC : MonoBehaviour
{
    // Panels
    public GameObject startRSVPPanel;
    public GameObject rsvpQuestions01Panel;
    public GameObject rsvpQuestions02Panel;
    public GameObject successCompletePanel;
    public GameObject failureCompletePanel;
    
    // Start is called before the first frame update
    void Start()
    {
        List<string> classificationList = new List<string> { "Freshmen", "Sophomore", "Junior", "Senior" };
        dropdown.options.Clear();
        foreach (string option in classificationList)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        dropdown.value = 0;
        dropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToStartRSVP()
    {
        startRSVPPanel.SetActive(false);
        rsvpQuestions01Panel.SetActive(true);
    }
    public void ToQuestions02()
    {
        rsvpQuestions01Panel.SetActive(false);
        rsvpQuestions02Panel.SetActive(true);
    }
    public void BackToQuestions01()
    {
        rsvpQuestions01Panel.SetActive(true);
        rsvpQuestions02Panel.SetActive(false);
    }
    public void CloseFailurePanel()
    {
        failureCompletePanel.SetActive(false);
    }

    public void ToDashboard()
    {
        SceneManager.LoadScene("Dashboard_PC");
    }
}
