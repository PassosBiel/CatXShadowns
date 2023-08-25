using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private Scene scene;
	void Start(){
		scene = SceneManager.GetActiveScene();
		Debug.Log(scene.name);
	}

	public void ChangeS(string cena){
		Debug.Log("Carregar "+cena);
		SceneManager.LoadScene(cena);
	}
}