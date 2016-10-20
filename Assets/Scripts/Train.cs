using UnityEngine;
using System.Collections;

public class Train : MonoBehaviour {

	public Movement mover = new Halt ();
	private Rigidbody rb;
	public ButtonTL BTL;
	public ButtonTR BTR;
	public ButtonBL BBL;
	public Rnd RAND = null;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		mover.move (rb);
		if (RAND != null) {
			RAND.rndm (BTL, BTR, BBL);
		}
		RAND = null;
	}
};

public abstract class Movement{
	public abstract void move (Rigidbody rb);
}

public class MRight: Movement{
	public override void move (Rigidbody rb){
		rb.AddForce (10, 0, 0);
	}
};

public class MLeft: Movement{
	public override void move (Rigidbody rb){
		rb.AddForce (-10, 0, 0);
	}
};

public class Halt: Movement{
	public override void move (Rigidbody rb){
		rb.AddForce (0, 0, 0);
	}
};

public abstract class Rnd{
	public abstract void rndm (ButtonTL BTL, ButtonTR BTR, ButtonBL BBL);
};

public class Rando: Rnd{
	public override void rndm(ButtonTL BTL, ButtonTR BTR, ButtonBL BBL){
		float number = UnityEngine.Random.Range (0, 6);
		if (number == 0) {
			BTL.Reset (0);
			BTR.Reset (1);
			BBL.Reset (2);
		}
		else if (number == 1) {
			BTL.Reset (0);
			BTR.Reset (2);
			BBL.Reset (1);
		}
		else if (number == 2) {
			BTL.Reset (1);
			BTR.Reset (0);
			BBL.Reset (2);
		}
		else if (number == 3) {
			BTL.Reset (1);
			BTR.Reset (2);
			BBL.Reset (0);
		}
		else if (number == 4) {
			BTL.Reset (2);
			BTR.Reset (1);
			BBL.Reset (0);
		}
		else if (number == 5) {
			BTL.Reset (2);
			BTR.Reset (0);
			BBL.Reset (1);
		}
	}
}