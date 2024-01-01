using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TileScript : MonoBehaviour
{
    private Vector3 originalPos;
    private Vector3 raisedPos;
    private Transform tileTransform;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        raisedPos = transform.position + new Vector3(0, 1, 0);
        tileTransform = this.gameObject.transform.GetChild(0);
    }
    private void OnMouseOver()
    {
        tileTransform.position = raisedPos;
        tileTransform.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 255);
    }

    private void OnMouseExit()
    {
        tileTransform.position = originalPos;
        tileTransform.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 255, 0);
	}
}
