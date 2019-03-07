//-----------------------------------------------------------------------
// <copyright file="Alert.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.UI.Behaviour
{
	using UnityEngine;
	using UnityEngine.Events;
	using UnityEngine.EventSystems;
	using UnityEngine.UI;

	public class Alert : MonoBehaviour
	{
		#region Unity Fields
		[SerializeField]
		Animator animator;

		[SerializeField]
		Button okButton;

		[SerializeField]
		RectTransform window;

		[SerializeField]
		Text message;

		[Header("Animations")]
		[SerializeField]
		string alertOpenAnimationStateName = "Base Layer.AlertOpen";

		[SerializeField]
		string alertCloseAnimationStateName = "Base Layer.AlertClose";
		#endregion

		#region Unity Events
		public UnityEvent OnOkButtonClick;
		#endregion

		#region Properties
		public Animator Animator
		{
			get
			{
				return this.animator != null ? this.animator : (this.animator = this.GetComponent<Animator>());
			}

			set
			{
				this.animator = value;
			}
		}

		public Button OkButton
		{
			get { return this.okButton; }
			set { this.okButton = value; }
		}

		public int AlertCloseAnimationStateNameHash { get; set; }

		public int AlertOpenAnimationStateNameHash { get; set; }

		public string AlertCloseAnimationStateName
		{
			get
			{
				return this.alertCloseAnimationStateName;
			}

			set
			{
				if (this.alertCloseAnimationStateName != value)
				{
					this.AlertCloseAnimationStateNameHash = Animator.StringToHash(value);
				}

				this.alertCloseAnimationStateName = value;
			}
		}

		public string AlertOpenAnimationStateName
		{
			get
			{
				return this.alertOpenAnimationStateName;
			}

			set
			{
				if (this.alertOpenAnimationStateName != value)
				{
					this.AlertOpenAnimationStateNameHash = Animator.StringToHash(value);
				}

				this.alertOpenAnimationStateName = value;
			}
		}

		public Text Message
		{
			get { return this.message; }
			set { this.message = value; }
		}
		#endregion

		#region Unity Methods
		protected virtual void Awake()
		{
			this.AlertOpenAnimationStateNameHash = Animator.StringToHash(this.AlertOpenAnimationStateName);
			this.AlertCloseAnimationStateNameHash = Animator.StringToHash(this.AlertCloseAnimationStateName);
		}

		protected virtual void OnEnable()
		{
			if (this.Animator != null)
			{
				this.Animator.Play(this.AlertOpenAnimationStateNameHash);
			}
		}
		#endregion

		#region Public Methods
		public void Close()
		{
			if (this.Animator != null)
			{
				this.Animator.Play(this.AlertCloseAnimationStateNameHash);

				return;
			}

			if (this.gameObject.activeSelf)
			{
				this.gameObject.SetActive(false);
			}
		}

		public void CloseOnOutsideWindow(BaseEventData data)
		{
			var d = (PointerEventData)data;
			if (!RectTransformUtility.RectangleContainsScreenPoint(this.window, d.position, d.pressEventCamera))
			{
				this.Close();
			}
		}

		public void InvokeOnOkButtonClick()
		{
			this.OnOkButtonClick.Invoke();
		}

		public void Open()
		{
			if (!this.gameObject.activeSelf)
			{
				this.gameObject.SetActive(true);
			}
		}

		public void ShowMessage(string value)
		{
			this.Open();
			this.Message.text = value;
		}
		#endregion
	}
}
