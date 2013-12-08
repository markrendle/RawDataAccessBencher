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
	/// <summary>Class which represents the entity 'StoreContact', mapped on table 'AdventureWorks.Sales.StoreContact'.</summary>
	[Table(Name="[Sales].[StoreContact]")]
	public partial class StoreContact : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_contactId;
		private System.Int32	_contactTypeId;
		private System.Int32	_customerId;
		private System.DateTime	_modifiedDate;
		private System.Guid	_rowguid;
		private EntityRef <Contact> _contact;
		private EntityRef <ContactType> _contactType;
		private EntityRef <Store> _store;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnContactIdChanging(System.Int32 value);
		partial void OnContactIdChanged();
		partial void OnContactTypeIdChanging(System.Int32 value);
		partial void OnContactTypeIdChanged();
		partial void OnCustomerIdChanging(System.Int32 value);
		partial void OnCustomerIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="StoreContact"/> class.</summary>
		public StoreContact()
		{
			_contact = default(EntityRef<Contact>);
			_contactType = default(EntityRef<ContactType>);
			_store = default(EntityRef<Store>);
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
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ContactId field. Mapped on target field 'ContactID'. </summary>
		[Column(Name="ContactID", Storage="_contactId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 ContactId
		{
			get	{ return _contactId; }
			set
			{
				if((_contactId != value))
				{
					if(_contact.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnContactIdChanging(value);
					SendPropertyChanging("ContactId");
					_contactId = value;
					SendPropertyChanged("ContactId");
					OnContactIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ContactTypeId field. Mapped on target field 'ContactTypeID'. </summary>
		[Column(Name="ContactTypeID", Storage="_contactTypeId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 ContactTypeId
		{
			get	{ return _contactTypeId; }
			set
			{
				if((_contactTypeId != value))
				{
					if(_contactType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnContactTypeIdChanging(value);
					SendPropertyChanging("ContactTypeId");
					_contactTypeId = value;
					SendPropertyChanged("ContactTypeId");
					OnContactTypeIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the CustomerId field. Mapped on target field 'CustomerID'. </summary>
		[Column(Name="CustomerID", Storage="_customerId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 CustomerId
		{
			get	{ return _customerId; }
			set
			{
				if((_customerId != value))
				{
					if(_store.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCustomerIdChanging(value);
					SendPropertyChanging("CustomerId");
					_customerId = value;
					SendPropertyChanged("CustomerId");
					OnCustomerIdChanged();
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

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		[Column(Name="rowguid", Storage="_rowguid", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="uniqueidentifier NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'StoreContact.Contact - Contact.StoreContacts (m:1)'</summary>
		[Association(Name="StoreContact_Contact555fba67abb0468ead9ff3ce1ca439c1", Storage="_contact", ThisKey="ContactId", IsForeignKey=true)] 
		public Contact Contact
		{
			get { return _contact.Entity; }
			set
			{
				Contact previousValue = _contact.Entity;
				if((previousValue != value) || (_contact.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Contact");
					if(previousValue != null)
					{
						_contact.Entity = null;
						previousValue.StoreContacts.Remove(this);
					}
					_contact.Entity = value;
					if(value == null)
					{
						_contactId = default(System.Int32);
					}
					else
					{
						value.StoreContacts.Add(this);
						_contactId = value.ContactId;
					}
					this.SendPropertyChanged("Contact");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'StoreContact.ContactType - ContactType.StoreContacts (m:1)'</summary>
		[Association(Name="StoreContact_ContactTypeed8daa6c79c94377b5b2979fc323c732", Storage="_contactType", ThisKey="ContactTypeId", IsForeignKey=true)] 
		public ContactType ContactType
		{
			get { return _contactType.Entity; }
			set
			{
				ContactType previousValue = _contactType.Entity;
				if((previousValue != value) || (_contactType.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("ContactType");
					if(previousValue != null)
					{
						_contactType.Entity = null;
						previousValue.StoreContacts.Remove(this);
					}
					_contactType.Entity = value;
					if(value == null)
					{
						_contactTypeId = default(System.Int32);
					}
					else
					{
						value.StoreContacts.Add(this);
						_contactTypeId = value.ContactTypeId;
					}
					this.SendPropertyChanged("ContactType");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'StoreContact.Store - Store.StoreContacts (m:1)'</summary>
		[Association(Name="StoreContact_Store96380eb7242241c29e22868af415e68f", Storage="_store", ThisKey="CustomerId", IsForeignKey=true)] 
		public Store Store
		{
			get { return _store.Entity; }
			set
			{
				Store previousValue = _store.Entity;
				if((previousValue != value) || (_store.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Store");
					if(previousValue != null)
					{
						_store.Entity = null;
						previousValue.StoreContacts.Remove(this);
					}
					_store.Entity = value;
					if(value == null)
					{
						_customerId = default(System.Int32);
					}
					else
					{
						value.StoreContacts.Add(this);
						_customerId = value.CustomerId;
					}
					this.SendPropertyChanged("Store");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649