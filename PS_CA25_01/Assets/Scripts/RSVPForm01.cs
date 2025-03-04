using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RSVPForm01 : MonoBehaviour
{
    
    [SerializeField] private TMP_InputField firstNameInputField;
    [SerializeField] private TMP_InputField lastNameInputField;
    [SerializeField] private TMP_InputField ucfEmailInputField;

    private string _firstName;
    private string _lastName;
    private string _ucfEmail;

    private static string base_url = "https://docs.google.com/forms/u/0/d/e/1FAIpQLScT8aoM3y-KVmp1gKHgW98lGG4CSUouD0DPnK32nBKt4tq54Q/formResponse";

    private static string firstName_Field = "entry.1952130145";
    private static string lasttName_Field = "entry.1874571834";
    private static string ucfEmail_Field = "entry.1061231665";

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
        _firstName = firstNameInputField.text;
        _lastName = lastNameInputField.text;
        _ucfEmail = ucfEmailInputField.text;

        StartCoroutine(Post(_firstName, _lastName, _ucfEmail));
    }

    private IEnumerator Post()
    {
        WWWForm form = new WWWForm();
        form.AddField(firstName_Field, _firstName);
        form.AddField(lastName_Field, _lastName);
        form.AddField(ucfEmail_Field, _ucfEmail);

        using UNityWebRequest www = UnityWebRequest.Post(base_url, form);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(www.error);
        }
        else Debug.Log("Success");
    }
}
