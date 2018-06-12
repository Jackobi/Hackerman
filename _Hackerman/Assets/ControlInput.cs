using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlInput : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCharRef;
    private GameObject possessionRef;

	void Awake ()
    {
        mainCharRef = GameObject.Find("CharacterRobotBoy");
	}
	
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.T) == true)
        {
            
        }
	}
}
