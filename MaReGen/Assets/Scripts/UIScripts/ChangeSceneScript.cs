using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para manejar las escenas


public class ChangeSceneScript : MonoBehaviour
{
    [SerializeField] private int targetScene;
    [SerializeField] private GameObject CanvasTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void switchCanvas(GameObject canvas)
    {
        canvas.SetActive(!canvas.gameObject.activeSelf);
    }
}
