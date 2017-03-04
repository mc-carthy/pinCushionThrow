﻿using UnityEngine;

public class Spawner : MonoBehaviour {

	[SerializeField]
    private GameObject pinPrefab;

    private void Update ()
    {
        if (Input.GetButtonDown ("Fire1"))
        {
            SpawnPin ();
        }
    }

    private void SpawnPin ()
    {
        Instantiate (pinPrefab, transform.position, transform.rotation);
    }

}
