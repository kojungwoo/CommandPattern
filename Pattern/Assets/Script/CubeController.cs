using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private InputHandler inputHandler;

	// Use this for initialization
	void Start () {
        inputHandler = new InputHandler();
	}
	
	// Update is called once per frame
	void Update () {
        //Command가 null이 아닌지 확인.
		if(inputHandler.GetCommand()!=null)
        {
            //엑터에게 해당Command를 실행시킴.
            inputHandler.GetCommand().Execute(RegistryCommandPattern.CURRENT_CUBE);
        }
	}
}
