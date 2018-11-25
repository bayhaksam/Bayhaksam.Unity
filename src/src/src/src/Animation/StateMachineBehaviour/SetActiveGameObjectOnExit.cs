//-----------------------------------------------------------------------
// <copyright file="SetActiveGameObjectOnExit.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Animation.StateMachineBehaviour
{
	using UnityEngine;

	public class SetActiveGameObjectOnExit : StateMachineBehaviour
	{
		#region Unity Fields
		[SerializeField]
		bool isActivate = true;

		[SerializeField]
		GameObject target;
		#endregion

		#region Properties
		public bool IsActivate
		{
			get { return this.isActivate; }
			set { this.isActivate = value; }
		}

		public GameObject Target
		{
			get { return this.target; }
			set { this.target = value; }
		}
		#endregion

		#region Unity Methods
		// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			(this.Target != null ? this.Target : animator.gameObject).SetActive(this.IsActivate);
		}
		#endregion
	}
}
