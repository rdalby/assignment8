﻿using UnityEngine;
using System.Collections;

public class GemSpawner : MonoBehaviour {

	public GameObject[] prefabs;

	// Use this for initialization
	void Start () {

		// infinite gem spawning function, asynchronous
		StartCoroutine(SpawnGems());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator SpawnGems() {
		while (true) {

			// only spawn 1 gem in a column makes it more rare
			// same instantiate as the coins except won't all be in the same row
			Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);

			// pause 3-20 seconds until the next gem spawns
			yield return new WaitForSeconds(Random.Range(3, 20));
		}
	}
}
