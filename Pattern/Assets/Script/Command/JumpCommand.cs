using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command {

    //점프시 점프의 파워를 담당하는 변수
    float JUMP = 15f;
    Vector3 jumpVector = Vector3.up;

    public void Execute(GameObject actor)
    {
        if (actor.transform.position.y < 1.5f)
            actor.GetComponent<Rigidbody>().AddForce(jumpVector*JUMP);
    }
}
