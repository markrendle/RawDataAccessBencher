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
	/// <summary>Class which represents the entity 'ProductDescription'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductDescription : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductDescription"/> class.</summary>
		public ProductDescription() : base()
		{
			this.ProductModelProductDescriptionCultures = new HashSet<ProductModelProductDescriptionCulture>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the Description field. </summary>
		[DataMember]
		public System.String Description { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the ProductDescriptionId field. </summary>
		[DataMember]
		public System.Int32 ProductDescriptionId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.ProductDescription - ProductDescription.ProductModelProductDescriptionCultures (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures { get; set;}
		#endregion
	}
}
