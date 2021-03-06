﻿

using UnityEngine;

public class Bullet : MonoBehaviour {

    private Transform target;
    public void Seek (Transform _target)
    {
        target = _target;
             
    }

    public float speed = 70f;
    public GameObject impactEffect;

	
	// Update is called once per frame
	void Update ()
    {

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            hitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame, Space.World);

	}

    void hitTarget ()
    {
        GameObject effectIns = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
