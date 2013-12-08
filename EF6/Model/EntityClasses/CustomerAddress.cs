﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CustomerAddress'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class CustomerAddress : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="CustomerAddress"/> class.</summary>
		public CustomerAddress() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the AddressId field. </summary>
		[DataMember]
		public System.Int32 AddressId { get; set;}
		/// <summary>Gets or sets the CustomerId field. </summary>
		[DataMember]
		public System.Int32 CustomerId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.Address - Address.CustomerAddresses (m:1)'</summary>
		[DataMember]
		public virtual Address Address { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.AddressType - AddressType.CustomerAddresses (m:1)'</summary>
		[DataMember]
		public virtual AddressType AddressType { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'CustomerAddress.Customer - Customer.CustomerAddresses (m:1)'</summary>
		[DataMember]
		public virtual Customer Customer { get; set;}
		#endregion
	}
}
