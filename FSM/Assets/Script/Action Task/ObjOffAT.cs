using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ObjOffAT : ActionTask {
		//had issues with animations so we are doing this instead :P
		public BBParameter<GameObject> gameObj;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			gameObj.value.SetActive(false);
			EndAction(true);
		}
	}
}