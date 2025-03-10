using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownToText_Classification : MonoBehaviour
{
    public TMP_Dropdown classificationDropdown; // Assign the dropdown in the inspector
    public TMP_Text classificationText; // Assign the text field in the inspector

    //public string classificationDropdownText;

    
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
        classificationText.text = selectedText;
        //classificationDropdownText = selectedText;
    }
}
