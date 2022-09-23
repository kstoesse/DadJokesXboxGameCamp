using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepBetweenLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        /*if (gameObject.tag.EndsWith("1"))
            Destroy(gameObject);*/
    }
}
