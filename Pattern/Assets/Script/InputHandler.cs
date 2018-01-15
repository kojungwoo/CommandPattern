using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//키입력 받아 키입력에 따른 해당명령을 객체화하여 보내주는 클래스
public class InputHandler{

    //각 행동별 클래스 변수를 지정
    private Command CmdJump, CmdMove, CmdFire;

    public Command GetCommand()
    {
        /*어떤 키가 입력되었는지에 따라 각각의 Command변수들을 Retrurn.*/
        if(Input.GetAxis("Jump")!=0)
        {
            //점프키를 눌렀을시 점프명령을 보내줌.
            CmdJump = new JumpCommand();
            return CmdJump;
        }

        if(Input.GetAxis("Horizontal")!=0||Input.GetAxis("Vertical")!=0)
        {
            //움직임이 있으면 Move명령을 보내주고 MoveCommand에 Horizontal, Vertical값을 넘겨줌
            CmdMove = new MoveCommand();
            MoveCommand.Vertical = Input.GetAxis("Vertical");
            MoveCommand.Horizontal = Input.GetAxis("Horizontal");
            return CmdMove;
        }

        if(Input.GetAxis("Fire1")!=0)
        {
            //발사는 마우스 위치에따라 나가게 처리.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 100))
            {
                //만약 클릭한 object의 테그가 Actor이면 Actor를 해당 게임오브젝트로 지정
                if (hit.transform.gameObject.tag == "Actor")
                    RegistryCommandPattern.CURRENT_CUBE = hit.transform.gameObject;
                 else if(RegistryCommandPattern.CURRENT_CUBE!=null)
                 {
                    //클릭했는데 Actor가 null이 아니면 해당 Actor에게 발사명령을 보냄.
                    CmdFire = new FireCommand();
                    FireCommand.targetPosition = hit.point;
                    return CmdFire;
                }
            }   
        }
        return null;
    }
}
