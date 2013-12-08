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
	/// <summary>Class which represents the entity 'SpecialOffer', mapped on table 'AdventureWorks.Sales.SpecialOffer'.</summary>
	[Table(Name="[Sales].[SpecialOffer]")]
	public partial class SpecialOffer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_category;
		private System.String	_description;
		private System.Decimal	_discountPct;
		private System.DateTime	_endDate;
		private Nullable<System.Int32>	_maxQty;
		private System.Int32	_minQty;
		private System.DateTime	_modifiedDate;
		private System.Guid	_rowguid;
		private System.Int32	_specialOfferId;
		private System.DateTime	_startDate;
		private System.String	_type;
		private EntitySet <SpecialOfferProduct> _specialOfferProducts;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnCategoryChanging(System.String value);
		partial void OnCategoryChanged();
		partial void OnDescriptionChanging(System.String value);
		partial void OnDescriptionChanged();
		partial void OnDiscountPctChanging(System.Decimal value);
		partial void OnDiscountPctChanged();
		partial void OnEndDateChanging(System.DateTime value);
		partial void OnEndDateChanged();
		partial void OnMaxQtyChanging(Nullable<System.Int32> value);
		partial void OnMaxQtyChanged();
		partial void OnMinQtyChanging(System.Int32 value);
		partial void OnMinQtyChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnSpecialOfferIdChanging(System.Int32 value);
		partial void OnSpecialOfferIdChanged();
		partial void OnStartDateChanging(System.DateTime value);
		partial void OnStartDateChanged();
		partial void OnTypeChanging(System.String value);
		partial void OnTypeChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SpecialOffer"/> class.</summary>
		public SpecialOffer()
		{
			_specialOfferProducts = new EntitySet<SpecialOfferProduct>(new Action<SpecialOfferProduct>(this.Attach_SpecialOfferProducts), new Action<SpecialOfferProduct>(this.Detach_SpecialOfferProducts) );
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
		private void Attach_SpecialOfferProducts(SpecialOfferProduct entity)
		{
			this.SendPropertyChanging("SpecialOfferProducts");
			entity.SpecialOffer = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SpecialOfferProducts(SpecialOfferProduct entity)
		{
			this.SendPropertyChanging("SpecialOfferProducts");
			entity.SpecialOffer = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the Category field. Mapped on target field 'Category'. </summary>
		[Column(Name="Category", Storage="_category", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Category
		{
			get	{ return _category; }
			set
			{
				if((_category != value))
				{
					OnCategoryChanging(value);
					SendPropertyChanging("Category");
					_category = value;
					SendPropertyChanged("Category");
					OnCategoryChanged();
				}
			}
		}

		/// <summary>Gets or sets the Description field. Mapped on target field 'Description'. </summary>
		[Column(Name="Description", Storage="_description", CanBeNull=false, DbType="nvarchar(255) NOT NULL")]
		public System.String Description
		{
			get	{ return _description; }
			set
			{
				if((_description != value))
				{
					OnDescriptionChanging(value);
					SendPropertyChanging("Description");
					_description = value;
					SendPropertyChanged("Description");
					OnDescriptionChanged();
				}
			}
		}

		/// <summary>Gets or sets the DiscountPct field. Mapped on target field 'DiscountPct'. </summary>
		[Column(Name="DiscountPct", Storage="_discountPct", CanBeNull=false, DbType="smallmoney NOT NULL")]
		public System.Decimal DiscountPct
		{
			get	{ return _discountPct; }
			set
			{
				if((_discountPct != value))
				{
					OnDiscountPctChanging(value);
					SendPropertyChanging("DiscountPct");
					_discountPct = value;
					SendPropertyChanged("DiscountPct");
					OnDiscountPctChanged();
				}
			}
		}

		/// <summary>Gets or sets the EndDate field. Mapped on target field 'EndDate'. </summary>
		[Column(Name="EndDate", Storage="_endDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime EndDate
		{
			get	{ return _endDate; }
			set
			{
				if((_endDate != value))
				{
					OnEndDateChanging(value);
					SendPropertyChanging("EndDate");
					_endDate = value;
					SendPropertyChanged("EndDate");
					OnEndDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the MaxQty field. Mapped on target field 'MaxQty'. </summary>
		[Column(Name="MaxQty", Storage="_maxQty", DbType="int NULL")]
		public Nullable<System.Int32> MaxQty
		{
			get	{ return _maxQty; }
			set
			{
				if((_maxQty != value))
				{
					OnMaxQtyChanging(value);
					SendPropertyChanging("MaxQty");
					_maxQty = value;
					SendPropertyChanged("MaxQty");
					OnMaxQtyChanged();
				}
			}
		}

		/// <summary>Gets or sets the MinQty field. Mapped on target field 'MinQty'. </summary>
		[Column(Name="MinQty", Storage="_minQty", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 MinQty
		{
			get	{ return _minQty; }
			set
			{
				if((_minQty != value))
				{
					OnMinQtyChanging(value);
					SendPropertyChanging("MinQty");
					_minQty = value;
					SendPropertyChanged("MinQty");
					OnMinQtyChanged();
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

		/// <summary>Gets or sets the SpecialOfferId field. Mapped on target field 'SpecialOfferID'. </summary>
		[Column(Name="SpecialOfferID", Storage="_specialOfferId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 SpecialOfferId
		{
			get	{ return _specialOfferId; }
			set
			{
				if((_specialOfferId != value))
				{
					OnSpecialOfferIdChanging(value);
					SendPropertyChanging("SpecialOfferId");
					_specialOfferId = value;
					SendPropertyChanged("SpecialOfferId");
					OnSpecialOfferIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the StartDate field. Mapped on target field 'StartDate'. </summary>
		[Column(Name="StartDate", Storage="_startDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime StartDate
		{
			get	{ return _startDate; }
			set
			{
				if((_startDate != value))
				{
					OnStartDateChanging(value);
					SendPropertyChanging("StartDate");
					_startDate = value;
					SendPropertyChanged("StartDate");
					OnStartDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Type field. Mapped on target field 'Type'. </summary>
		[Column(Name="Type", Storage="_type", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Type
		{
			get	{ return _type; }
			set
			{
				if((_type != value))
				{
					OnTypeChanging(value);
					SendPropertyChanging("Type");
					_type = value;
					SendPropertyChanged("Type");
					OnTypeChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.SpecialOffer - SpecialOffer.SpecialOfferProducts (m:1)'</summary>
		[Association(Name="SpecialOfferProduct_SpecialOffer747caa5a54be47e3a5ef4d0bd2defd18", Storage="_specialOfferProducts", OtherKey="SpecialOfferId")]
		public EntitySet<SpecialOfferProduct> SpecialOfferProducts
		{
			get { return this._specialOfferProducts; }
			set { this._specialOfferProducts.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649