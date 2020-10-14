using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireComponent : MonoBehaviour
{

    public GameObject AmmoPrefab;
    public int FirePower;

    void Start()
    {

    }

    public void Fire()
    {
        GameObject ammoShot = Instantiate(AmmoPrefab, transform.position, Quaternion.identity);
        ammoShot.GetComponent<Rigidbody>().AddForce(-transform.right * FirePower, ForceMode.Impulse);
    }

}
