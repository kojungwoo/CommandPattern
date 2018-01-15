using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCommand : Command {
    //발사 명령시 처리를 담당하는 클래스
  
    // targetPositon : 마우스가 클릭한 위치를 저장 shootVector : actor의 위치와 targetPosition간의 방향벡터변수
    public static Vector3 targetPosition, shootVector;
    
    BulletMade _BulletMade;//BulletMade의 클래스 변수
    public void Execute(GameObject actor)
    {
        _BulletMade = GameObject.Find("BulletMade").GetComponent<BulletMade>();
         shootVector = targetPosition - actor.transform.position;
         shootVector.Normalize();
        _BulletMade.CreateBullet(actor.transform.position);
    }

   
}
