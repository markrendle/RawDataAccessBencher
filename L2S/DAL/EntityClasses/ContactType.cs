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
	/// <summary>Class which represents the entity 'ContactType', mapped on table 'AdventureWorks.Person.ContactType'.</summary>
	[Table(Name="[Person].[ContactType]")]
	public partial class ContactType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_contactTypeId;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private EntitySet <StoreContact> _storeContacts;
		private EntitySet <VendorContact> _vendorContacts;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnContactTypeIdChanging(System.Int32 value);
		partial void OnContactTypeIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ContactType"/> class.</summary>
		public ContactType()
		{
			_storeContacts = new EntitySet<StoreContact>(new Action<StoreContact>(this.Attach_StoreContacts), new Action<StoreContact>(this.Detach_StoreContacts) );
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
		private void Attach_StoreContacts(StoreContact entity)
		{
			this.SendPropertyChanging("StoreContacts");
			entity.ContactType = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_StoreContacts(StoreContact entity)
		{
			this.SendPropertyChanging("StoreContacts");
			entity.ContactType = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_VendorContacts(VendorContact entity)
		{
			this.SendPropertyChanging("VendorContacts");
			entity.ContactType = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_VendorContacts(VendorContact entity)
		{
			this.SendPropertyChanging("VendorContacts");
			entity.ContactType = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the ContactTypeId field. Mapped on target field 'ContactTypeID'. </summary>
		[Column(Name="ContactTypeID", Storage="_contactTypeId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 ContactTypeId
		{
			get	{ return _contactTypeId; }
			set
			{
				if((_contactTypeId != value))
				{
					OnContactTypeIdChanging(value);
					SendPropertyChanging("ContactTypeId");
					_contactTypeId = value;
					SendPropertyChanged("ContactTypeId");
					OnContactTypeIdChanged();
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

		/// <summary>Represents the navigator which is mapped onto the association 'StoreContact.ContactType - ContactType.StoreContacts (m:1)'</summary>
		[Association(Name="StoreContact_ContactTypeed8daa6c79c94377b5b2979fc323c732", Storage="_storeContacts", OtherKey="ContactTypeId")]
		public EntitySet<StoreContact> StoreContacts
		{
			get { return this._storeContacts; }
			set { this._storeContacts.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'VendorContact.ContactType - ContactType.VendorContacts (m:1)'</summary>
		[Association(Name="VendorContact_ContactType04e342c152cc494eb9ef14709eb700d1", Storage="_vendorContacts", OtherKey="ContactTypeId")]
		public EntitySet<VendorContact> VendorContacts
		{
			get { return this._vendorContacts; }
			set { this._vendorContacts.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649