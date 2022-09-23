using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadNextLevel : MonoBehaviour
{
    //public ChangeArea a;
    private void OnTriggerEnter(Collider other)
    {
        
        //a.Area();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}
