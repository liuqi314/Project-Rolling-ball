using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Version : MonoBehaviour
{

    private Text _versionNumberText;
    
    // Start is called before the first frame update
    void Start()
    {
        _versionNumberText = GetComponent<Text>();
        _versionNumberText.text = "VERSION:" + Application.version;


    }

    
}
