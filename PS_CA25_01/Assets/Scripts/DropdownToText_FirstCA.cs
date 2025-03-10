using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownToText_FirstCA : MonoBehaviour
{
    public TMP_Dropdown firstCADropdown; // Assign the dropdown in the inspector
    public TMP_Text firstCAText; // Assign the text field in the inspector
    //public string firstCADropdownText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDropdownChanged(TMP_Dropdown dropdown)
    {
        int selectedIndex = dropdown.value;
        string selectedText = dropdown.options[selectedIndex].text;
        firstCAText.text = selectedText;
        //firstCADropdownText = selectedText;
    }
}
