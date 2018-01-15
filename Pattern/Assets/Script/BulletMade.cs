using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMade : MonoBehaviour {

    public GameObject Bullet;

	public void CreateBullet(Vector3 MadePosition)
    {
        Instantiate(Bullet, MadePosition, Quaternion.identity);
    }
}
