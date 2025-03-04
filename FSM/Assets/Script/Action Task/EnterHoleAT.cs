using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;


namespace NodeCanvas.Tasks.Actions {

	public class EnterHoleAT : ActionTask {
        private NavMeshAgent navAgent;

        protected override string OnInit() {
            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
		}

		protected override void OnExecute() {
            //Hide the Prairie Dog
            agent.transform.position = new Vector3(100, 0, 100);
            navAgent.ResetPath();

            EndAction(true);
		}
	}
}