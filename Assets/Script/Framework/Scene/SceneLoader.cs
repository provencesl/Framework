using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader> {


    public void LoadScene()
    {
        SceneManager.LoadScene("Loading");

    }

    private IEnumerator LoadAfterTime()
    {
        yield return new WaitForSeconds(1.0f);
        LoadScene("Game");
    }



    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
