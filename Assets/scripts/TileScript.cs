using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    private Vector3 originalPos;
    private Vector3 raisedPos;
    private Transform tileTransform;

    private bool isRaised = false;

    // Start is called before the first frame update
    private void Start()
    {
        originalPos = transform.position;
        raisedPos = transform.position + new Vector3(0, 1, 0);
        tileTransform = this.gameObject.transform.GetChild(0);
    }

    private void Update()
    {
        if (isRaised && transform.position != raisedPos) transform.position += new Vector3(0, 0.1f, 0);
        else if (!isRaised && transform.position != originalPos) transform.position += new Vector3(0, -0.1f, 0);
    }

    private void OnMouseOver()
    {
        Debug.Log("hovering");

        isRaised = true;
    }

    private void OnMouseExit()
    {
        Debug.Log("exiting");

        isRaised = false;
    }
}
