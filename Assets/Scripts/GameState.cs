using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameState : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _scoretext;
    [SerializeField] private PlayerController playerController;
    private Coroutine coroutine;
    //private int score;
    

    private void OnEnable()
    {
        coroutine = StartCoroutine(AddScore(1f));
        _scoretext.enabled = true;
        playerController.enabled = true;
    }

    private void OnDisable()
    {
        StopCoroutine(coroutine);
        //_scoretext.enabled = false;
        //playerController.enabled = false;
    }
    // Update is called once per frame
   
    
    private IEnumerator AddScore(float time)
    {
        WaitForSeconds wait = new WaitForSeconds(time);
        while (true)
        {
            _scoretext.text = "" + GameValues.gameScore;
            GameValues.gameScore += 1;         
            yield return wait;

           
        }
    }
    public void ChangeScore(int point )
    {
        GameValues.gameScore += point;
        _scoretext.text = "" + GameValues.gameScore;
    }

}
