using System.Collections;
using System.Collections.Generic;
using UnityEngine;
usung UnityEngine.ScenceManagement;

public class DangerComponent : MonoBehaviour
{
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player")){

        int scenceIndex = SceneManager.GetActiveScence().buildIndex;

        SceneManager.LoadScence(scenceIndex);
        }
    }
}
