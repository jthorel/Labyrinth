﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public void LoadScene(string name) {
		SceneManager.LoadScene (name);
	}

	public void QuitScene (){
		Application.Quit ();
	}
}
