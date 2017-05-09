﻿using UnityEngine;

[CreateAssetMenu (menuName = "AI/Actions/Chase")]
public class Action_Chase : Action {

	public override void Init(StateController controller) {
		var control = controller as Enemy_StateController;
        control.anim.SetTrigger("ChaseState");
	}

	public override void Act(StateController controller) {
		chase(controller);
	}

	private void chase(StateController controller) {
		var enemyControl = controller as Enemy_StateController;

		enemyControl.navMeshAgent.destination = enemyControl.chaseTarget.position;
		enemyControl.navMeshAgent.isStopped = false;
	}
}