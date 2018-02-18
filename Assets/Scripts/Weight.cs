//Kevin Macario 17369
//Laboratorio 5: Effectors, joints, partículas y raycast
//Clase de animacion de union de un peso con una plataforma
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weight : MonoBehaviour {
    private DistanceJoint2D distanceJoint;
    private LineRenderer line;

    // Use this for initialization
    void Start () {
        distanceJoint = GetComponent<DistanceJoint2D>();
        line = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, distanceJoint.connectedBody.transform.position);
	}
}
