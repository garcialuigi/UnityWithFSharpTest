using UnityEngine;
using System.Collections;
using LibraryTest;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
    private SimpleComponent x;
	void Start () {
        x = new SimpleComponent();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(x.stuff);
	}
}
