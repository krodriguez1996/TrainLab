using UnityEngine;
using System.Collections;

public class Random : Move {

	public override void execute (Train t)
	{
		t.RAND = new Rando ();
	}
}
