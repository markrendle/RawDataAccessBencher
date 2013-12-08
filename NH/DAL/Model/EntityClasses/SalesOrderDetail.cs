﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SalesOrderDetail'</summary>
	public partial class SalesOrderDetail
	{
		#region Class Member Declarations
		private SalesOrderHeader _salesOrderHeader;
		private SpecialOfferProduct _specialOfferProduct;
		private System.String _carrierTrackingNumber;
		private System.Decimal _lineTotal;
		private System.DateTime _modifiedDate;
		private System.Int16 _orderQty;
		private System.Guid _rowguid;
		private System.Int32 _salesOrderDetailId;
		private System.Decimal _unitPrice;
		private System.Decimal _unitPriceDiscount;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="SalesOrderDetail"/> class.</summary>
		public SalesOrderDetail() : base()
		{
			_lineTotal = default(System.Decimal);
			_salesOrderDetailId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			return object.ReferenceEquals(this, obj);
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the CarrierTrackingNumber field. </summary>	
		public virtual System.String CarrierTrackingNumber
		{ 
			get { return _carrierTrackingNumber; }
			set { _carrierTrackingNumber = value; }
		}

		/// <summary>Gets the LineTotal field. </summary>	
		public virtual System.Decimal LineTotal
		{ 
			get { return _lineTotal; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Gets or sets the OrderQty field. </summary>	
		public virtual System.Int16 OrderQty
		{ 
			get { return _orderQty; }
			set { _orderQty = value; }
		}

		/// <summary>Gets or sets the Rowguid field. </summary>	
		public virtual System.Guid Rowguid
		{ 
			get { return _rowguid; }
			set { _rowguid = value; }
		}

		/// <summary>Gets the SalesOrderDetailId field. </summary>	
		public virtual System.Int32 SalesOrderDetailId
		{ 
			get { return _salesOrderDetailId; }
		}

		/// <summary>Gets or sets the UnitPrice field. </summary>	
		public virtual System.Decimal UnitPrice
		{ 
			get { return _unitPrice; }
			set { _unitPrice = value; }
		}

		/// <summary>Gets or sets the UnitPriceDiscount field. </summary>	
		public virtual System.Decimal UnitPriceDiscount
		{ 
			get { return _unitPriceDiscount; }
			set { _unitPriceDiscount = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SalesOrderHeader - SalesOrderHeader.SalesOrderDetails (m:1)'</summary>
		public virtual SalesOrderHeader SalesOrderHeader
		{
			get { return _salesOrderHeader; }
			set { _salesOrderHeader = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderDetail.SpecialOfferProduct - SpecialOfferProduct.SalesOrderDetails (m:1)'</summary>
		public virtual SpecialOfferProduct SpecialOfferProduct
		{
			get { return _specialOfferProduct; }
			set { _specialOfferProduct = value; }
		}
		
		#endregion
	}
}
