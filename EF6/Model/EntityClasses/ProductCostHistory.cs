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
	/// <summary>Class which represents the entity 'ProductCostHistory'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductCostHistory : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductCostHistory"/> class.</summary>
		public ProductCostHistory() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the EndDate field. </summary>
		[DataMember]
		public Nullable<System.DateTime> EndDate { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the ProductId field. </summary>
		[DataMember]
		public System.Int32 ProductId { get; set;}
		/// <summary>Gets or sets the StandardCost field. </summary>
		[DataMember]
		public System.Decimal StandardCost { get; set;}
		/// <summary>Gets or sets the StartDate field. </summary>
		[DataMember]
		public System.DateTime StartDate { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductCostHistory.Product - Product.ProductCostHistories (m:1)'</summary>
		[DataMember]
		public virtual Product Product { get; set;}
		#endregion
	}
}
