using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    public void Fire()
    {
        Debug.Log("Fire");
    }

    public void Skill()
    {
        Debug.Log("Skill");
    }

    public void WeaponChange()
    {
        Debug.Log("Change");
    }

    public void Jump()
    {
        Debug.Log("Jump");
    }
}

public class CubeCommand : MonoBehaviour {

    Command command;
    InputHandler _handler;
    Actor _actor;
	// Use this for initialization
	void Start () {
        _actor = new Actor();
        _handler = GetComponent<InputHandler>();
	}
	
	// Update is called once per frame
	void Update () {
        command = _handler.GetCommand();
        if (command != null)
            command.Execute(_actor);
	}
}
