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
	/// <summary>Class which represents the entity 'PurchaseOrderDetail'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class PurchaseOrderDetail : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderDetail"/> class.</summary>
		public PurchaseOrderDetail() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the DueDate field. </summary>
		[DataMember]
		public System.DateTime DueDate { get; set;}
		/// <summary>Gets or sets the LineTotal field. </summary>
		[DataMember]
		public System.Decimal LineTotal { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the OrderQty field. </summary>
		[DataMember]
		public System.Int16 OrderQty { get; set;}
		/// <summary>Gets or sets the PurchaseOrderDetailId field. </summary>
		[DataMember]
		public System.Int32 PurchaseOrderDetailId { get; set;}
		/// <summary>Gets or sets the PurchaseOrderId field. </summary>
		[DataMember]
		public System.Int32 PurchaseOrderId { get; set;}
		/// <summary>Gets or sets the ReceivedQty field. </summary>
		[DataMember]
		public System.Decimal ReceivedQty { get; set;}
		/// <summary>Gets or sets the RejectedQty field. </summary>
		[DataMember]
		public System.Decimal RejectedQty { get; set;}
		/// <summary>Gets or sets the StockedQty field. </summary>
		[DataMember]
		public System.Decimal StockedQty { get; set;}
		/// <summary>Gets or sets the UnitPrice field. </summary>
		[DataMember]
		public System.Decimal UnitPrice { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderDetail.Product - Product.PurchaseOrderDetails (m:1)'</summary>
		[DataMember]
		public virtual Product Product { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderDetail.PurchaseOrderHeader - PurchaseOrderHeader.PurchaseOrderDetails (m:1)'</summary>
		[DataMember]
		public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set;}
		#endregion
	}
}
