﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Vendor', mapped on table 'AdventureWorks.Purchasing.Vendor'.</summary>
	[Table(Name="[Purchasing].[Vendor]")]
	public partial class Vendor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_accountNumber;
		private System.Boolean	_activeFlag;
		private System.Byte	_creditRating;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Boolean	_preferredVendorStatus;
		private System.String	_purchasingWebServiceUrl;
		private System.Int32	_vendorId;
		private EntitySet <ProductVendor> _productVendors;
		private EntitySet <PurchaseOrderHeader> _purchaseOrderHeaders;
		private EntitySet <VendorAddress> _vendorAddresses;
		private EntitySet <VendorContact> _vendorContacts;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAccountNumberChanging(System.String value);
		partial void OnAccountNumberChanged();
		partial void OnActiveFlagChanging(System.Boolean value);
		partial void OnActiveFlagChanged();
		partial void OnCreditRatingChanging(System.Byte value);
		partial void OnCreditRatingChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnPreferredVendorStatusChanging(System.Boolean value);
		partial void OnPreferredVendorStatusChanged();
		partial void OnPurchasingWebServiceUrlChanging(System.String value);
		partial void OnPurchasingWebServiceUrlChanged();
		partial void OnVendorIdChanging(System.Int32 value);
		partial void OnVendorIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Vendor"/> class.</summary>
		public Vendor()
		{
			_productVendors = new EntitySet<ProductVendor>(new Action<ProductVendor>(this.Attach_ProductVendors), new Action<ProductVendor>(this.Detach_ProductVendors) );
			_purchaseOrderHeaders = new EntitySet<PurchaseOrderHeader>(new Action<PurchaseOrderHeader>(this.Attach_PurchaseOrderHeaders), new Action<PurchaseOrderHeader>(this.Detach_PurchaseOrderHeaders) );
			_vendorAddresses = new EntitySet<VendorAddress>(new Action<VendorAddress>(this.Attach_VendorAddresses), new Action<VendorAddress>(this.Detach_VendorAddresses) );
			_vendorContacts = new EntitySet<VendorContact>(new Action<VendorContact>(this.Attach_VendorContacts), new Action<VendorContact>(this.Detach_VendorContacts) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_ProductVendors(ProductVendor entity)
		{
			this.SendPropertyChanging("ProductVendors");
			entity.Vendor = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_ProductVendors(ProductVendor entity)
		{
			this.SendPropertyChanging("ProductVendors");
			entity.Vendor = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_PurchaseOrderHeaders(PurchaseOrderHeader entity)
		{
			this.SendPropertyChanging("PurchaseOrderHeaders");
			entity.Vendor = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_PurchaseOrderHeaders(PurchaseOrderHeader entity)
		{
			this.SendPropertyChanging("PurchaseOrderHeaders");
			entity.Vendor = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_VendorAddresses(VendorAddress entity)
		{
			this.SendPropertyChanging("VendorAddresses");
			entity.Vendor = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_VendorAddresses(VendorAddress entity)
		{
			this.SendPropertyChanging("VendorAddresses");
			entity.Vendor = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_VendorContacts(VendorContact entity)
		{
			this.SendPropertyChanging("VendorContacts");
			entity.Vendor = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_VendorContacts(VendorContact entity)
		{
			this.SendPropertyChanging("VendorContacts");
			entity.Vendor = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. Mapped on target field 'AccountNumber'. </summary>
		[Column(Name="AccountNumber", Storage="_accountNumber", CanBeNull=false, DbType="nvarchar(15) NOT NULL")]
		public System.String AccountNumber
		{
			get	{ return _accountNumber; }
			set
			{
				if((_accountNumber != value))
				{
					OnAccountNumberChanging(value);
					SendPropertyChanging("AccountNumber");
					_accountNumber = value;
					SendPropertyChanged("AccountNumber");
					OnAccountNumberChanged();
				}
			}
		}

		/// <summary>Gets or sets the ActiveFlag field. Mapped on target field 'ActiveFlag'. </summary>
		[Column(Name="ActiveFlag", Storage="_activeFlag", CanBeNull=false, DbType="bit NOT NULL")]
		public System.Boolean ActiveFlag
		{
			get	{ return _activeFlag; }
			set
			{
				if((_activeFlag != value))
				{
					OnActiveFlagChanging(value);
					SendPropertyChanging("ActiveFlag");
					_activeFlag = value;
					SendPropertyChanged("ActiveFlag");
					OnActiveFlagChanged();
				}
			}
		}

		/// <summary>Gets or sets the CreditRating field. Mapped on target field 'CreditRating'. </summary>
		[Column(Name="CreditRating", Storage="_creditRating", CanBeNull=false, DbType="tinyint NOT NULL")]
		public System.Byte CreditRating
		{
			get	{ return _creditRating; }
			set
			{
				if((_creditRating != value))
				{
					OnCreditRatingChanging(value);
					SendPropertyChanging("CreditRating");
					_creditRating = value;
					SendPropertyChanged("CreditRating");
					OnCreditRatingChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		[Column(Name="Name", Storage="_name", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the PreferredVendorStatus field. Mapped on target field 'PreferredVendorStatus'. </summary>
		[Column(Name="PreferredVendorStatus", Storage="_preferredVendorStatus", CanBeNull=false, DbType="bit NOT NULL")]
		public System.Boolean PreferredVendorStatus
		{
			get	{ return _preferredVendorStatus; }
			set
			{
				if((_preferredVendorStatus != value))
				{
					OnPreferredVendorStatusChanging(value);
					SendPropertyChanging("PreferredVendorStatus");
					_preferredVendorStatus = value;
					SendPropertyChanged("PreferredVendorStatus");
					OnPreferredVendorStatusChanged();
				}
			}
		}

		/// <summary>Gets or sets the PurchasingWebServiceUrl field. Mapped on target field 'PurchasingWebServiceURL'. </summary>
		[Column(Name="PurchasingWebServiceURL", Storage="_purchasingWebServiceUrl", DbType="nvarchar(1024) NULL")]
		public System.String PurchasingWebServiceUrl
		{
			get	{ return _purchasingWebServiceUrl; }
			set
			{
				if((_purchasingWebServiceUrl != value))
				{
					OnPurchasingWebServiceUrlChanging(value);
					SendPropertyChanging("PurchasingWebServiceUrl");
					_purchasingWebServiceUrl = value;
					SendPropertyChanged("PurchasingWebServiceUrl");
					OnPurchasingWebServiceUrlChanged();
				}
			}
		}

		/// <summary>Gets or sets the VendorId field. Mapped on target field 'VendorID'. </summary>
		[Column(Name="VendorID", Storage="_vendorId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 VendorId
		{
			get	{ return _vendorId; }
			set
			{
				if((_vendorId != value))
				{
					OnVendorIdChanging(value);
					SendPropertyChanging("VendorId");
					_vendorId = value;
					SendPropertyChanged("VendorId");
					OnVendorIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.Vendor - Vendor.ProductVendors (m:1)'</summary>
		[Association(Name="ProductVendor_Vendor18cb37fc8ab5434291dd10925cffb5e3", Storage="_productVendors", OtherKey="VendorId")]
		public EntitySet<ProductVendor> ProductVendors
		{
			get { return this._productVendors; }
			set { this._productVendors.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Vendor - Vendor.PurchaseOrderHeaders (m:1)'</summary>
		[Association(Name="PurchaseOrderHeader_Vendordf935cd8a11e4c289c3b92e488d4b427", Storage="_purchaseOrderHeaders", OtherKey="VendorId")]
		public EntitySet<PurchaseOrderHeader> PurchaseOrderHeaders
		{
			get { return this._purchaseOrderHeaders; }
			set { this._purchaseOrderHeaders.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'VendorAddress.Vendor - Vendor.VendorAddresses (m:1)'</summary>
		[Association(Name="VendorAddress_Vendor9aefaf8ff0654d3883801658809c9958", Storage="_vendorAddresses", OtherKey="VendorId")]
		public EntitySet<VendorAddress> VendorAddresses
		{
			get { return this._vendorAddresses; }
			set { this._vendorAddresses.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'VendorContact.Vendor - Vendor.VendorContacts (m:1)'</summary>
		[Association(Name="VendorContact_Vendor5a3c581c8dad430bb421560f317e7c4e", Storage="_vendorContacts", OtherKey="VendorId")]
		public EntitySet<VendorContact> VendorContacts
		{
			get { return this._vendorContacts; }
			set { this._vendorContacts.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649