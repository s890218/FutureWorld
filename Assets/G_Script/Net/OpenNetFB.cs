using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNetFB : MonoBehaviour {

	private string m_SelfFb = "https://www.facebook.com/";


	void OnClickFB () {
		Application.OpenURL(m_SelfFb);
	}
	
}
