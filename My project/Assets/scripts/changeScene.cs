using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    private string Scene1 = "Scene 1";
    private string Scene2 = "Scene 2";
     GameObject player;
     GameObject mainCamera;
     GameObject camera;
     GameObject Light;
     GameObject floor;
    int scene;
    // Use this for initialization
  
    void Start(){

        scene = SceneManager.GetActiveScene().buildIndex;
        player = GameObject.Find("player");
        mainCamera = GameObject.Find("Main Camera");
        camera = GameObject.Find("Cameratest");
        Light = GameObject.Find("Directional Light");
    }

    public void LoadB()
    {

       
       switch(scene)
       {
        case 0:
        DontDestroyOnLoad(mainCamera);
        DontDestroyOnLoad(camera);
        DontDestroyOnLoad(Light);
        DontDestroyOnLoad(player);
        Debug.Log("Load 2");
        SceneManager.LoadScene(Scene2);
        break;
        // case 1:
        // Debug.Log("Load 1");
        //  DontDestroyOnLoad(player);
        // SceneManager.LoadScene(Scene1);
        //   Destroy(mainCamera);
        // Destroy(camera);
        // Destroy(Light);
        // Destroy(GameObject.Find("player"));
        // break;
        // default:
        // Debug.Log("error");
        // break;
      
       }
   
       
    }
}
