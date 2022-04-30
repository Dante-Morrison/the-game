using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
             gameObject.GetComponent<Renderer> ().material.color = Color.green;
            switchScene(scene);
        }
    }

    void OnTriggerExit(Collider other)
    {
         gameObject.GetComponent<Renderer> ().material.color = Color.white;
    }

    // Update is called once per frame
    public void switchScene(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
