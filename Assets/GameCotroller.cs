using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCotroller : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject winnerLabelObject;

    public void Update ()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString ();

        if(count == 0){
            winnerLabelObject.SetActive(true);
        

        }
    }
}
