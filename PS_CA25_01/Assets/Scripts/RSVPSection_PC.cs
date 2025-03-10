using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using TMPro;

public class RSVPSection_PC : MonoBehaviour
{
    // Panels
    public GameObject startRSVPPanel;
    public GameObject rsvpQuestions01Panel;
    public GameObject rsvpQuestions02Panel;
    public GameObject successCompletePanel;
    public GameObject failureCompletePanel;

    // Dropdowns
    public TMP_Dropdown classificationDropdown;
    public TMP_Dropdown majorDropdown;
    public TMP_Dropdown pathwayDropdown;
    public TMP_Dropdown firstCADropdown;
    public TMP_Dropdown attendanceDropdown;
    public TMP_Dropdown attendTypeDropdown;
    
    // Start is called before the first frame update
    void Awake()
    {
        // Classification Dropdown
        List<string> classificationList = new List<string> { "Freshmen", "Sophomore", "Junior", "Senior" };
        classificationDropdown.options.Clear();
        foreach (string option in classificationList)
        {
            classificationDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //classificationDropdown.value = 0;
        //classificationDropdown.RefreshShownValue();

        // Major Dropdown
        List<string> majorList = new List<string> { "Biology", "Biomedical Sciences", "Computer Science", "Engineering", "Health Sciences", "Information Technology" };
        majorDropdown.options.Clear();
        foreach (string option in majorList)
        {
            majorDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //majorDropdown.value = 0;
        //majorDropdown.RefreshShownValue();

        // Pathway Dropdown
        List<string> pathwayList = new List<string> { "Professionals Pathway", "Academic Advancers Pathway", "Researchers Pathway", "Experiencers Pathway" };
        pathwayDropdown.options.Clear();
        foreach (string option in pathwayList)
        {
            pathwayDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //pathwayDropdown.value = 0;
        //pathwayDropdown.RefreshShownValue();

        // First Career Academy Dropdown
        List<string> firstCAList = new List<string> { "Yes", "No" };
        firstCADropdown.options.Clear();
        foreach (string option in firstCAList)
        {
            firstCADropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //firstCADropdown.value = 0;
        //firstCADropdown.RefreshShownValue();

        // Attendance Dropdown
        List<string> attendanceList = new List<string> { "Yes", "No" };
        attendanceDropdown.options.Clear();
        foreach (string option in attendanceList)
        {
            attendanceDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //attendanceDropdown.value = 0;
        //attendanceDropdown.RefreshShownValue();

        // Attending Type Dropdown
        List<string> attendTypeList = new List<string> { "Not Attending", "Some of the Time", "Half the Time", "Majority of the Time", "Entire Time" };
        attendTypeDropdown.options.Clear();
        foreach (string option in attendTypeList)
        {
            attendTypeDropdown.options.Add(new TMP_Dropdown.OptionData(option));
        }
        //attendTypeDropdown.value = 0;
        //attendTypeDropdown.RefreshShownValue();
    }

    void Start()
    {

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
