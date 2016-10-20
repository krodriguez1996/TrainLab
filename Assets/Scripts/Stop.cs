using UnityEngine;
using System.Collections;

public class Stop : Move {

	public override void execute (Train t)
	{
		t.mover = new Halt ();
	}
}
