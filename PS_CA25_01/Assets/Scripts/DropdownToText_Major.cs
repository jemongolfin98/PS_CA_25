using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownToText_Major : MonoBehaviour
{
    public TMP_Dropdown majorDropdown; // Assign the dropdown in the inspector
    public TMP_Text majorText; // Assign the text field in the inspector
    //public string majorDropdownText;

    
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
        majorText.text = selectedText;
        //majorDropdownText = selectedText;
    }
}
