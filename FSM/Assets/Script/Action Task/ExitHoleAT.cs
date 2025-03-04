using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ExitHoleAT : ActionTask {
		public BBParameter<Transform> target;

        protected override string OnInit() {
			return null;
		}
		protected override void OnExecute() {
            agent.transform.position = target.value.position;
            EndAction(true);
		}
	}
}