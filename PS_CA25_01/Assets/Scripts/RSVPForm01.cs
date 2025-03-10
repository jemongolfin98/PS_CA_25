using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;

public class RSVPForm01 : MonoBehaviour
{
    
    // Page 1
    [SerializeField] private TMP_InputField firstNameInputField;
    [SerializeField] private TMP_InputField lastNameInputField;
    [SerializeField] private TMP_InputField ucfEmailInputField;
    [SerializeField] private TMP_Dropdown classificationDropdown;
    [SerializeField] private TMP_Dropdown majorDropdown;
    [SerializeField] private TMP_InputField majorEngineeringInputField;

    private string _firstName;
    private string _lastName;
    private string _ucfEmail;
    private string _classification;
    private string _major;
    private string _majorEngineering;

    // Page 2
    [SerializeField] private TMP_Dropdown pathwayDropdown;
    [SerializeField] private TMP_Dropdown firstCADropdown;
    [SerializeField] private TMP_InputField previewInputField;
    [SerializeField] private TMP_Dropdown attendanceDropdown;
    [SerializeField] private TMP_Dropdown attendTypeDropdown;

    private string _pathway;
    private string _firstCA;
    private string _preview;
    private string _attendance;
    private string _attendType;

    // Game Object -  Scripts
    public GameObject dttClassification;
    public GameObject dttMajor;
    public GameObject dttPathway;
    public GameObject dttFirstCA;
    public GameObject dttAttendance;
    public GameObject dttAttendType;

    // Text
    public TMP_Text classificationText;
    public TMP_Text majorText;
    public TMP_Text pathwayText;
    public TMP_Text firstCAText;
    public TMP_Text attendanceText;
    public TMP_Text attendTypeText;


    private static string base_url = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScT8aoM3y-KVmp1gKHgW98lGG4CSUouD0DPnK32nBKt4tq54Q/formResponse";

    // Page 1
    private static string firstName_Field = "entry.1952130145";
    private static string lastName_Field = "entry.1874571834";
    private static string ucfEmail_Field = "entry.1061231665";
    private static string classification_Field = "entry.2082250700";
    private static string major_Field = "entry.1439717615";
    private static string majorEngineering_Field = "entry.1347561912";

    // Page 2
    private static string pathway_Field = "entry.1674354979";
    private static string firstCA_Field = "entry.1426676836";
    private static string preview_Field = "entry.466237129";
    private static string attendance_Field = "entry.1003761649";
    private static string attendType_Field = "entry.1920263368";


    // Panels
    public GameObject successCompletePanel;
    public GameObject failureCompletePanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Send()
    {
        // Page 1
        _firstName = firstNameInputField.text;
        _lastName = lastNameInputField.text;
        _ucfEmail = ucfEmailInputField.text;
        //_classification = dttClassification.GetComponent<DropdownToText_Classification>().classificationDropdownText;
        _classification = classificationText.text;
        //_major = dttMajor.GetComponent<DropdownToText_Major>().majorDropdownText;
        _major = majorText.text;
        _majorEngineering = majorEngineeringInputField.text;

        //Page 2
        //_pathway = dttPathway.GetComponent<DropdownToText_Pathway>().pathwayDropdownText;
        _pathway = pathwayText.text;
        //_firstCA = dttFirstCA.GetComponent<DropdownToText_FirstCA>().firstCADropdownText;
        _firstCA = firstCAText.text;
        _preview = previewInputField.text;
        //_attendance = dttAttendance.GetComponent<DropdownToText_Attendance>().attendanceDropdownText;
        _attendance = attendanceText.text;
        //_attendType = dttAttendType.GetComponent<DropdownToText_AttendType>().attendTypeDropdownText;
        _attendType = attendTypeText.text;

        StartCoroutine(Post());
    }

    private IEnumerator Post()
    {
        WWWForm form = new WWWForm();

        // Page 1
        form.AddField(firstName_Field, _firstName);
        form.AddField(lastName_Field, _lastName);
        form.AddField(ucfEmail_Field, _ucfEmail);
        form.AddField(classification_Field, _classification);
        form.AddField(major_Field, _major);
        form.AddField(majorEngineering_Field, _majorEngineering);

        // Page 2
        form.AddField(pathway_Field, _pathway);
        form.AddField(firstCA_Field, _firstCA);
        form.AddField(preview_Field, _preview);
        form.AddField(attendance_Field, _attendance);
        form.AddField(attendType_Field, _attendType);

        using UnityWebRequest www = UnityWebRequest.Post(base_url, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(www.error);
            successCompletePanel.SetActive(false);
            failureCompletePanel.SetActive(true);
        }
        else
        {
            Debug.Log("Success");
            successCompletePanel.SetActive(true);
            failureCompletePanel.SetActive(false);
        }
    }
}
