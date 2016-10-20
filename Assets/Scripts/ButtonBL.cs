using UnityEngine;
using System.Collections;

public class ButtonBL : MonoBehaviour {

	private MeshRenderer mesh;
	private Move mover= new Stop();
	public Train t;

	// Use this for initialization
	void Start () {
		mesh = GetComponent<MeshRenderer> ();
	}

	void OnMouseDown() {
		mover.execute (t);
		mesh.material.color = Color.red;
	}
	public void Reset(int num){
		if (num == 0) {
			mover = new Backward ();
		} else if (num == 1) {
			mover = new Forward ();
		} else
			mover = new Stop ();
	}

}
