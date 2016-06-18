using UnityEngine;
using System.Collections;

public class Transformer : MonoBehaviour {
    
    public float rotationSpeed;
	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(3f, 3f, 3f);
        GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
	}
	
	// Update is called once per frame
	void Update () {

        //Rotamos el objeto
        transform.Rotate(
            0f, 
            rotationSpeed*Time.deltaTime, 
            0f, 
            Space.Self);
	}
}
