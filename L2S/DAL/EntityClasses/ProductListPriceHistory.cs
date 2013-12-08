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
	/// <summary>Class which represents the entity 'ProductListPriceHistory', mapped on table 'AdventureWorks.Production.ProductListPriceHistory'.</summary>
	[Table(Name="[Production].[ProductListPriceHistory]")]
	public partial class ProductListPriceHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private Nullable<System.DateTime>	_endDate;
		private System.Decimal	_listPrice;
		private System.DateTime	_modifiedDate;
		private System.Int32	_productId;
		private System.DateTime	_startDate;
		private EntityRef <Product> _product;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnEndDateChanging(Nullable<System.DateTime> value);
		partial void OnEndDateChanged();
		partial void OnListPriceChanging(System.Decimal value);
		partial void OnListPriceChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnStartDateChanging(System.DateTime value);
		partial void OnStartDateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductListPriceHistory"/> class.</summary>
		public ProductListPriceHistory()
		{
			_product = default(EntityRef<Product>);
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
		/// <summary>Gets or sets the EndDate field. Mapped on target field 'EndDate'. </summary>
		[Column(Name="EndDate", Storage="_endDate", DbType="datetime NULL")]
		public Nullable<System.DateTime> EndDate
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

		/// <summary>Gets or sets the ListPrice field. Mapped on target field 'ListPrice'. </summary>
		[Column(Name="ListPrice", Storage="_listPrice", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal ListPrice
		{
			get	{ return _listPrice; }
			set
			{
				if((_listPrice != value))
				{
					OnListPriceChanging(value);
					SendPropertyChanging("ListPrice");
					_listPrice = value;
					SendPropertyChanged("ListPrice");
					OnListPriceChanged();
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

		/// <summary>Gets or sets the ProductId field. Mapped on target field 'ProductID'. </summary>
		[Column(Name="ProductID", Storage="_productId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 ProductId
		{
			get	{ return _productId; }
			set
			{
				if((_productId != value))
				{
					if(_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductIdChanging(value);
					SendPropertyChanging("ProductId");
					_productId = value;
					SendPropertyChanged("ProductId");
					OnProductIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the StartDate field. Mapped on target field 'StartDate'. </summary>
		[Column(Name="StartDate", Storage="_startDate", CanBeNull=false, DbType="datetime NOT NULL", IsPrimaryKey=true)]
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

		/// <summary>Represents the navigator which is mapped onto the association 'ProductListPriceHistory.Product - Product.ProductListPriceHistories (m:1)'</summary>
		[Association(Name="ProductListPriceHistory_Productb4100bc2d44446ebb7deb788281045b9", Storage="_product", ThisKey="ProductId", IsForeignKey=true)] 
		public Product Product
		{
			get { return _product.Entity; }
			set
			{
				Product previousValue = _product.Entity;
				if((previousValue != value) || (_product.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Product");
					if(previousValue != null)
					{
						_product.Entity = null;
						previousValue.ProductListPriceHistories.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.ProductListPriceHistories.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649