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
	/// <summary>Class which represents the entity 'ProductVendor', mapped on table 'AdventureWorks.Purchasing.ProductVendor'.</summary>
	[Table(Name="[Purchasing].[ProductVendor]")]
	public partial class ProductVendor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_averageLeadTime;
		private Nullable<System.Decimal>	_lastReceiptCost;
		private Nullable<System.DateTime>	_lastReceiptDate;
		private System.Int32	_maxOrderQty;
		private System.Int32	_minOrderQty;
		private System.DateTime	_modifiedDate;
		private Nullable<System.Int32>	_onOrderQty;
		private System.Int32	_productId;
		private System.Decimal	_standardPrice;
		private System.String	_unitMeasureCode;
		private System.Int32	_vendorId;
		private EntityRef <Product> _product;
		private EntityRef <UnitMeasure> _unitMeasure;
		private EntityRef <Vendor> _vendor;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnAverageLeadTimeChanging(System.Int32 value);
		partial void OnAverageLeadTimeChanged();
		partial void OnLastReceiptCostChanging(Nullable<System.Decimal> value);
		partial void OnLastReceiptCostChanged();
		partial void OnLastReceiptDateChanging(Nullable<System.DateTime> value);
		partial void OnLastReceiptDateChanged();
		partial void OnMaxOrderQtyChanging(System.Int32 value);
		partial void OnMaxOrderQtyChanged();
		partial void OnMinOrderQtyChanging(System.Int32 value);
		partial void OnMinOrderQtyChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnOnOrderQtyChanging(Nullable<System.Int32> value);
		partial void OnOnOrderQtyChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnStandardPriceChanging(System.Decimal value);
		partial void OnStandardPriceChanged();
		partial void OnUnitMeasureCodeChanging(System.String value);
		partial void OnUnitMeasureCodeChanged();
		partial void OnVendorIdChanging(System.Int32 value);
		partial void OnVendorIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ProductVendor"/> class.</summary>
		public ProductVendor()
		{
			_product = default(EntityRef<Product>);
			_unitMeasure = default(EntityRef<UnitMeasure>);
			_vendor = default(EntityRef<Vendor>);
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
		/// <summary>Gets or sets the AverageLeadTime field. Mapped on target field 'AverageLeadTime'. </summary>
		[Column(Name="AverageLeadTime", Storage="_averageLeadTime", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 AverageLeadTime
		{
			get	{ return _averageLeadTime; }
			set
			{
				if((_averageLeadTime != value))
				{
					OnAverageLeadTimeChanging(value);
					SendPropertyChanging("AverageLeadTime");
					_averageLeadTime = value;
					SendPropertyChanged("AverageLeadTime");
					OnAverageLeadTimeChanged();
				}
			}
		}

		/// <summary>Gets or sets the LastReceiptCost field. Mapped on target field 'LastReceiptCost'. </summary>
		[Column(Name="LastReceiptCost", Storage="_lastReceiptCost", DbType="money NULL")]
		public Nullable<System.Decimal> LastReceiptCost
		{
			get	{ return _lastReceiptCost; }
			set
			{
				if((_lastReceiptCost != value))
				{
					OnLastReceiptCostChanging(value);
					SendPropertyChanging("LastReceiptCost");
					_lastReceiptCost = value;
					SendPropertyChanged("LastReceiptCost");
					OnLastReceiptCostChanged();
				}
			}
		}

		/// <summary>Gets or sets the LastReceiptDate field. Mapped on target field 'LastReceiptDate'. </summary>
		[Column(Name="LastReceiptDate", Storage="_lastReceiptDate", DbType="datetime NULL")]
		public Nullable<System.DateTime> LastReceiptDate
		{
			get	{ return _lastReceiptDate; }
			set
			{
				if((_lastReceiptDate != value))
				{
					OnLastReceiptDateChanging(value);
					SendPropertyChanging("LastReceiptDate");
					_lastReceiptDate = value;
					SendPropertyChanged("LastReceiptDate");
					OnLastReceiptDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the MaxOrderQty field. Mapped on target field 'MaxOrderQty'. </summary>
		[Column(Name="MaxOrderQty", Storage="_maxOrderQty", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 MaxOrderQty
		{
			get	{ return _maxOrderQty; }
			set
			{
				if((_maxOrderQty != value))
				{
					OnMaxOrderQtyChanging(value);
					SendPropertyChanging("MaxOrderQty");
					_maxOrderQty = value;
					SendPropertyChanged("MaxOrderQty");
					OnMaxOrderQtyChanged();
				}
			}
		}

		/// <summary>Gets or sets the MinOrderQty field. Mapped on target field 'MinOrderQty'. </summary>
		[Column(Name="MinOrderQty", Storage="_minOrderQty", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 MinOrderQty
		{
			get	{ return _minOrderQty; }
			set
			{
				if((_minOrderQty != value))
				{
					OnMinOrderQtyChanging(value);
					SendPropertyChanging("MinOrderQty");
					_minOrderQty = value;
					SendPropertyChanged("MinOrderQty");
					OnMinOrderQtyChanged();
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

		/// <summary>Gets or sets the OnOrderQty field. Mapped on target field 'OnOrderQty'. </summary>
		[Column(Name="OnOrderQty", Storage="_onOrderQty", DbType="int NULL")]
		public Nullable<System.Int32> OnOrderQty
		{
			get	{ return _onOrderQty; }
			set
			{
				if((_onOrderQty != value))
				{
					OnOnOrderQtyChanging(value);
					SendPropertyChanging("OnOrderQty");
					_onOrderQty = value;
					SendPropertyChanged("OnOrderQty");
					OnOnOrderQtyChanged();
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

		/// <summary>Gets or sets the StandardPrice field. Mapped on target field 'StandardPrice'. </summary>
		[Column(Name="StandardPrice", Storage="_standardPrice", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal StandardPrice
		{
			get	{ return _standardPrice; }
			set
			{
				if((_standardPrice != value))
				{
					OnStandardPriceChanging(value);
					SendPropertyChanging("StandardPrice");
					_standardPrice = value;
					SendPropertyChanged("StandardPrice");
					OnStandardPriceChanged();
				}
			}
		}

		/// <summary>Gets or sets the UnitMeasureCode field. Mapped on target field 'UnitMeasureCode'. </summary>
		[Column(Name="UnitMeasureCode", Storage="_unitMeasureCode", CanBeNull=false, DbType="nchar(3) NOT NULL")]
		public System.String UnitMeasureCode
		{
			get	{ return _unitMeasureCode; }
			set
			{
				if((_unitMeasureCode != value))
				{
					if(_unitMeasure.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnUnitMeasureCodeChanging(value);
					SendPropertyChanging("UnitMeasureCode");
					_unitMeasureCode = value;
					SendPropertyChanged("UnitMeasureCode");
					OnUnitMeasureCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the VendorId field. Mapped on target field 'VendorID'. </summary>
		[Column(Name="VendorID", Storage="_vendorId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 VendorId
		{
			get	{ return _vendorId; }
			set
			{
				if((_vendorId != value))
				{
					if(_vendor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnVendorIdChanging(value);
					SendPropertyChanging("VendorId");
					_vendorId = value;
					SendPropertyChanged("VendorId");
					OnVendorIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.Product - Product.ProductVendors (m:1)'</summary>
		[Association(Name="ProductVendor_Product1bf4057500c24bc2ab36330450010ae9", Storage="_product", ThisKey="ProductId", IsForeignKey=true)] 
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
						previousValue.ProductVendors.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.ProductVendors.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.UnitMeasure - UnitMeasure.ProductVendors (m:1)'</summary>
		[Association(Name="ProductVendor_UnitMeasurece4b3e6c67de4291b5c1b129dcb0edbe", Storage="_unitMeasure", ThisKey="UnitMeasureCode", IsForeignKey=true)] 
		public UnitMeasure UnitMeasure
		{
			get { return _unitMeasure.Entity; }
			set
			{
				UnitMeasure previousValue = _unitMeasure.Entity;
				if((previousValue != value) || (_unitMeasure.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("UnitMeasure");
					if(previousValue != null)
					{
						_unitMeasure.Entity = null;
						previousValue.ProductVendors.Remove(this);
					}
					_unitMeasure.Entity = value;
					if(value == null)
					{
						_unitMeasureCode = default(System.String);
					}
					else
					{
						value.ProductVendors.Add(this);
						_unitMeasureCode = value.UnitMeasureCode;
					}
					this.SendPropertyChanged("UnitMeasure");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.Vendor - Vendor.ProductVendors (m:1)'</summary>
		[Association(Name="ProductVendor_Vendor18cb37fc8ab5434291dd10925cffb5e3", Storage="_vendor", ThisKey="VendorId", IsForeignKey=true)] 
		public Vendor Vendor
		{
			get { return _vendor.Entity; }
			set
			{
				Vendor previousValue = _vendor.Entity;
				if((previousValue != value) || (_vendor.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Vendor");
					if(previousValue != null)
					{
						_vendor.Entity = null;
						previousValue.ProductVendors.Remove(this);
					}
					_vendor.Entity = value;
					if(value == null)
					{
						_vendorId = default(System.Int32);
					}
					else
					{
						value.ProductVendors.Add(this);
						_vendorId = value.VendorId;
					}
					this.SendPropertyChanged("Vendor");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649