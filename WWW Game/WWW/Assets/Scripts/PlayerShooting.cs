using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject projectile;

    public float visualCd;
    public float cd = 5f;
    public string key;
    float cdInt = 0;

	// Update is called once per frame
	void Update () {

        if(Input.GetButtonUp (key) && cdInt <= 0 )
        {
            cdInt = cd;
            Instantiate(projectile, transform.position, transform.rotation);

        }
        cdInt -= Time.deltaTime;
        visualCd = cdInt;
	}
}
