using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    void Awake() {
        Debug.Log("Awake message");
    }
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
	}
}
