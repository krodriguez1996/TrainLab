using UnityEngine;
using System.Collections;

public class Forward : Move 
{

	public override void execute (Train t)
	{
		t.mover = new MRight ();
	}
}
