using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ExitHoleAT : ActionTask {
		public BBParameter<Transform> target;
        //animations objects
        public BBParameter<GameObject> spriteObj;
        public BBParameter<GameObject> digObj;
        protected override string OnInit() {
			return null;
		}
		protected override void OnExecute() {
			// animate
            spriteObj.value.SetActive(true);
            digObj.value.SetActive(true);

            agent.transform.position = target.value.position;
            EndAction(true);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
        }
	}
}