    using UnityEngine;
using System.Collections;

public class meteor : MonoBehaviour {
    public Transform cratere;
    public int truc = 0;
	// Use this for initialization
	void Start () {

	}
	
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.name == "terrain") ;
        {
            Instantiate(cratere, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
