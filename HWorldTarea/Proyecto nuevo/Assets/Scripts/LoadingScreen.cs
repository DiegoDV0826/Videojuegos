using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject loadingScreenObj;
    public Slider Slider;

    AsyncOperation async;

    public void LoadScreen()
    {
        StartCoroutine(LoadingScreenEnum());
    }
    IEnumerator LoadingScreenEnum() 
    {
        loadingScreenObj.SetActive(true);
        async = SceneManager.LoadSceneAsync(0);
        async.allowSceneActivation = false;
        while(async.isDone == false)
        {
            Slider.value = async.progress;
            if(async.progress == 0.9f)
            {
                Slider.value = 1f;
                async.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
