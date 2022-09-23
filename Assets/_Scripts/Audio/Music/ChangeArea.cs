using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class ChangeArea : MonoBehaviour
{
    private static FMOD.Studio.EventInstance instance;
    public EventReference fmodEvent;
    public int area;
    string scene;
    Scene ascene;
    //FMODEventPlayableBehavior beh;

    // Start is called before the first frame update
    public static ChangeArea nstance { get; private set; }
    private void Awake()
    {
        if (nstance == null)
            nstance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        instance = RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
        SceneManager.activeSceneChanged += GetSceneName;
        //area = beh.
    }

    // Update is called once per frame
    void Update()
    {
        //GetSceneName();
        scene = SceneManager.GetActiveScene().name;       
        Debug.Log(scene);
        Area();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "music")
            Area();
    }

    

    public void Area()
    {
        Debug.Log(area);
        if (scene == "Level1.1")
            area = 1;
        else if (scene == "Level1.2")
            area = 2;
        else if (scene == "Level1.3")
            area = 3;
        instance.setParameterByName("area", area);
    }
    public void GetSceneName(Scene current, Scene next)
    {
        //current = SceneManager.GetActiveScene();
        string currentName = current.name;
        if (currentName == null)
        {
            //Area();
        }
        /*ebug.Log(currentName);
        scene = current.name;
        Area();*/
        
    }
    
}
