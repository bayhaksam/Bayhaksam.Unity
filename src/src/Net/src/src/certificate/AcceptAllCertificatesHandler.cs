//-----------------------------------------------------------------------
// <copyright file="AcceptAllCertificatesHandler.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Unity.Net
{
	using UnityEngine.Networking;

	public class AcceptAllCertificatesHandler : CertificateHandler
	{
		protected override bool ValidateCertificate(byte[] certificateData) => true;
	}
}
