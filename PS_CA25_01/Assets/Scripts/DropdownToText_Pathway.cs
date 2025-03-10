using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropdownToText_Pathway : MonoBehaviour
{
    public TMP_Dropdown pathwayDropdown; // Assign the dropdown in the inspector
    public TMP_Text pathwayText; // Assign the text field in the inspector
    //public string pathwayDropdownText;

    
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
        pathwayText.text = selectedText;
        //pathwayDropdownText = selectedText;
    }
}
