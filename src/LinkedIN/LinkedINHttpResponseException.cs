﻿using System;
using System.Net;
using System.Runtime.Serialization;

namespace LinkedIN
{
	/// <summary>
	/// This is exception is thrown when a request to the LinkedIN response did not result in the expected response.
	/// </summary>
	[Serializable]
	public class LinkedINHttpResponseException : LinkedINException
	{
		#region Constuctor
		/// <summary>
		/// Constructs an <see cref="LinkedINHttpResponseException"/>.
		/// </summary>
		/// <param name="expectedStatusCode">The expected <see cref="HttpStatusCode"/> of the response.</param>
		/// <param name="actualStatusCode">The actual <see cref="HttpStatusCode"/> of the response.</param>
		/// <param name="message">The message descriving the cause of this exception.</param>
		/// <param name="inner">The inner <see cref="Exception"/>.</param>
		public LinkedINHttpResponseException( HttpStatusCode expectedStatusCode, HttpStatusCode actualStatusCode, string message, Exception inner ) : base( message, inner )
		{
			// set values
			ExpectedStatusCode = expectedStatusCode;
			ActualStatusCode = actualStatusCode;
		}
		/// <summary>
		/// Serialization constructor.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected LinkedINHttpResponseException( SerializationInfo info, StreamingContext context ) : base( info, context )
		{
		}

        /// <summary>
        /// Serialization GetObjectData.
        /// </summary>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        // Breakpoint placed on the following line never gets hit:
        throw new NotImplementedException();
        }
		#endregion
		#region Private Fields
		/// <summary>
		/// The expected <see cref="HttpStatusCode"/> of the response.
		/// </summary>
		public HttpStatusCode ExpectedStatusCode { get; private set; }
		/// <summary>
		/// The actual <see cref="HttpStatusCode"/> of the response.
		/// </summary>
		public HttpStatusCode ActualStatusCode { get; private set; }
		#endregion
	}
}