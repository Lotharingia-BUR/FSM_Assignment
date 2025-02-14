using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class ScatterAT : ActionTask {
		public BBParameter<List<Transform>> holePositions;
        public BBParameter<Transform> target;

		public float maxDectectionRadius;
		private float currentDectectionRadius;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			currentDectectionRadius = maxDectectionRadius;
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			foreach(Transform holePosition in holePositions.value)
			{
				float distanceToHole = (holePosition.position - agent.transform.position).magnitude;

                Debug.Log(distanceToHole);
				if(currentDectectionRadius > distanceToHole)
				{
					currentDectectionRadius = distanceToHole;
					target.value = holePosition;
                }
			}
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}