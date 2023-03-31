using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform BulletPos;
    public GameObject playerBullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PlayerShoot();
        }
    }
    void PlayerShoot()
    {
        Instantiate(playerBullet, BulletPos.position, BulletPos.rotation);
    }
}
