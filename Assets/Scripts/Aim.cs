using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    Rigidbody rigidB;
    [SerializeField]
    Camera cam; 
	// Use this for initialization
	void Start () {
        rigidB = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
        
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        AimLogic();

    }

    void AimLogic()
    {
        float _leftRightValue = Input.GetAxisRaw("Mouse X");
        float _upDownValue = Input.GetAxisRaw("Mouse Y");
        Vector3 _rotationX = new Vector3(-_upDownValue, 0, 0);
        Vector3 _rotationY = new Vector3(0, _leftRightValue, 0);
        //Vector3 _rotation = new Vector3(_upDownValue, _leftRightValue, 0);
        //rigidB.MoveRotation(rigidB.rotation * Quaternion.Euler(_rotation));
        rigidB.MoveRotation(rigidB.rotation * Quaternion.Euler(_rotationY));
        cam.transform.Rotate(_rotationX / 0.5f);
        //cam2.transform.Rotate(_rotationY / 0.5f);
            
    }
}
