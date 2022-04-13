using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string scene;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            switchScene(scene);
        }
    }

    // Update is called once per frame
    void switchScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
