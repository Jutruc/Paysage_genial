using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour {

    public float intervalTime;
    public GameObject asteroidePrefab;
    public float rayonMap;
    public float hauteurMin;
    public float hauteurMax;

    // Use this for initialization
    void Start () {
        InvokeRepeating("CreateAsteroid", 0f, intervalTime);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateAsteroid() {

        float positionX = Random.Range(this.gameObject.transform.position.x - rayonMap, this.gameObject.transform.position.x + rayonMap);
        float positionZ = Random.Range(this.gameObject.transform.position.z - rayonMap, this.gameObject.transform.position.z + rayonMap);

        float hauteurPop = Random.Range(hauteurMin, hauteurMax);

        Instantiate(asteroidePrefab, new Vector3(positionX, hauteurPop, positionZ), Quaternion.Euler(Vector3.zero));

    }

}
