using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ValidPassword : MonoBehaviour {
	
 	string Passwd;
	string Cpasswd;
	public InputField Inputpasswd;
	public InputField InputCpasswd;
	private Color invalid = new Color(0.9F, 0.3F, 0.3F);
	private Color valid = new Color(0.604F, 0.804F,0.196F);

	public void passwdEdit(string value) {
		Passwd = value;
		if (String.Equals(Passwd, Cpasswd)) {
			Inputpasswd.GetComponent<Image>().color = valid;
			InputCpasswd.GetComponent<Image>().color = valid;
		} 
		else {
			Inputpasswd.GetComponent<Image>().color = invalid;
			InputCpasswd.GetComponent<Image>().color = invalid;
		}
	}

	public void CpasswdEdit(string value) {
		Cpasswd = value;
		if (String.Equals(Passwd, Cpasswd)) {
			Inputpasswd.GetComponent<Image>().color = valid;
			InputCpasswd.GetComponent<Image>().color = valid;
		}
		else {
			Inputpasswd.GetComponent<Image>().color = invalid;
			InputCpasswd.GetComponent<Image>().color = invalid;
		}
	}
}
