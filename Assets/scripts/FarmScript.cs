using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmScript : MonoBehaviour
{
    [SerializeField] private List<string> phases = new List<string>();
    private LinkedList<string> linkedPhases;

    [SerializeField] private float timeBetweenPhases = 5f;


    // Start is called before the first frame update
    void Start()
    {
        //transfer the elements from the phases to the linkedPhases
		linkedPhases = new LinkedList<string>(phases);

		StartCoroutine(Grow());
    }

    private IEnumerator Grow()
    {
        LinkedListNode<string> currentPhase = linkedPhases.First;

        do
        {
            GrowTile(currentPhase.Value);
            yield return new WaitForSeconds(timeBetweenPhases);
            currentPhase = currentPhase.Next;
        }
        while (currentPhase.Next != null);

        FinishGrowth();
    }

    private void GrowTile(string currentPhase)
    {
        Debug.Log("farm tile is currently on phase:" + currentPhase);
    }

    private void FinishGrowth()
    {
        Debug.Log("farm tile is done growing.");
    }
}
