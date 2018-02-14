using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEffector : MonoBehaviour {
    public float time = 0;
    public bool activated;
    public GameObject child;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        time += Time.deltaTime;
        if (time >= 3) {
            activated = !activated;
            child.SetActive(activated);
            time = 0;
        }
    }
}
