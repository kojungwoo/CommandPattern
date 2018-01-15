using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command {

    //이동시 이동벡터를 담당.
    Vector3 movement;
    public static float Vertical, Horizontal;

    public void Execute(GameObject actor)
    {
        movement = new Vector3(Horizontal, 0, Vertical);
        actor.transform.Translate(movement*Time.deltaTime*5);
    }
}
