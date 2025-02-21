using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class PlayerControllerAT : ActionTask {

		public float velocity = 10;

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() 
		{
		}

		// Allows player to interact with the scene
		protected override void OnUpdate() {
            // Movments all messded up cause scene is rotated and I havent gotten to fixing it:(
			if(Input.GetKey(KeyCode.W)) 
			{
                agent.transform.position += (Vector3.left) * velocity * Time.deltaTime;
                
			}
            if (Input.GetKey(KeyCode.S))
            {
                agent.transform.position += (Vector3.right) * velocity * Time.deltaTime;
                
            }
            if (Input.GetKey(KeyCode.A))
            {
                agent.transform.position += (Vector3.back) * velocity * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                agent.transform.position += (Vector3.forward) * velocity * Time.deltaTime;
            }

        }
	}
}