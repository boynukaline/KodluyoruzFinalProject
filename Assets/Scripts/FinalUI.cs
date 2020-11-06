using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _finalScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        _finalScoreText.text = "" + GameValues.gameScore;
        GameValues.gameScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
