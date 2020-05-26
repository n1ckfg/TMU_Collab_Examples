using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreator : MonoBehaviour {

	public CubeMover prefab;
	public int numCubes = 10;

	void Start () {
		for (int i = 0; i < numCubes; i++) {
			Instantiate(prefab, Vector3.zero, Quaternion.identity);
		}
	}

}
