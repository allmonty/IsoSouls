﻿using UnityEngine;

[CreateAssetMenu (menuName = "AI/Decisions/HitReceived")]
public class Decision_HitReceived : Decision {

	bool hit = false;

	public override bool Decide(StateController controller) {
		return wasHit(controller as Enemy_StateController);
	}

	private bool wasHit(Enemy_StateController controller) {
		return hit;
	}

	public void setWasHitted()
	{
		hit = true;
	}
}
