using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnRunner : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadSceneAsync(0);
        DontDestroyOnLoad(this.gameObject);
    }
}
