using UnityEngine;
using System.Collections;

public class Backward : Move {

	public override void execute (Train t)
	{
		t.mover = new MLeft ();
	}
}
