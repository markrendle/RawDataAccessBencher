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
	/// <summary>Class which represents the entity 'SalesTerritory', mapped on table 'AdventureWorks.Sales.SalesTerritory'.</summary>
	[Table(Name="[Sales].[SalesTerritory]")]
	public partial class SalesTerritory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Decimal	_costLastYear;
		private System.Decimal	_costYtd;
		private System.String	_countryRegionCode;
		private System.String	_group;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Guid	_rowguid;
		private System.Decimal	_salesLastYear;
		private System.Decimal	_salesYtd;
		private System.Int32	_territoryId;
		private EntitySet <Customer> _customers;
		private EntitySet <SalesOrderHeader> _salesOrderHeaders;
		private EntitySet <SalesPerson> _salesPeople;
		private EntitySet <SalesTerritoryHistory> _salesTerritoryHistories;
		private EntitySet <StateProvince> _stateProvinces;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnCostLastYearChanging(System.Decimal value);
		partial void OnCostLastYearChanged();
		partial void OnCostYtdChanging(System.Decimal value);
		partial void OnCostYtdChanged();
		partial void OnCountryRegionCodeChanging(System.String value);
		partial void OnCountryRegionCodeChanged();
		partial void OnGroupChanging(System.String value);
		partial void OnGroupChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnSalesLastYearChanging(System.Decimal value);
		partial void OnSalesLastYearChanged();
		partial void OnSalesYtdChanging(System.Decimal value);
		partial void OnSalesYtdChanged();
		partial void OnTerritoryIdChanging(System.Int32 value);
		partial void OnTerritoryIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SalesTerritory"/> class.</summary>
		public SalesTerritory()
		{
			_customers = new EntitySet<Customer>(new Action<Customer>(this.Attach_Customers), new Action<Customer>(this.Detach_Customers) );
			_salesOrderHeaders = new EntitySet<SalesOrderHeader>(new Action<SalesOrderHeader>(this.Attach_SalesOrderHeaders), new Action<SalesOrderHeader>(this.Detach_SalesOrderHeaders) );
			_salesPeople = new EntitySet<SalesPerson>(new Action<SalesPerson>(this.Attach_SalesPeople), new Action<SalesPerson>(this.Detach_SalesPeople) );
			_salesTerritoryHistories = new EntitySet<SalesTerritoryHistory>(new Action<SalesTerritoryHistory>(this.Attach_SalesTerritoryHistories), new Action<SalesTerritoryHistory>(this.Detach_SalesTerritoryHistories) );
			_stateProvinces = new EntitySet<StateProvince>(new Action<StateProvince>(this.Attach_StateProvinces), new Action<StateProvince>(this.Detach_StateProvinces) );
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
		private void Attach_Customers(Customer entity)
		{
			this.SendPropertyChanging("Customers");
			entity.SalesTerritory = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_Customers(Customer entity)
		{
			this.SendPropertyChanging("Customers");
			entity.SalesTerritory = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.SalesTerritory = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesOrderHeaders(SalesOrderHeader entity)
		{
			this.SendPropertyChanging("SalesOrderHeaders");
			entity.SalesTerritory = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesPeople(SalesPerson entity)
		{
			this.SendPropertyChanging("SalesPeople");
			entity.SalesTerritory = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesPeople(SalesPerson entity)
		{
			this.SendPropertyChanging("SalesPeople");
			entity.SalesTerritory = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesTerritoryHistories(SalesTerritoryHistory entity)
		{
			this.SendPropertyChanging("SalesTerritoryHistories");
			entity.SalesTerritory = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesTerritoryHistories(SalesTerritoryHistory entity)
		{
			this.SendPropertyChanging("SalesTerritoryHistories");
			entity.SalesTerritory = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_StateProvinces(StateProvince entity)
		{
			this.SendPropertyChanging("StateProvinces");
			entity.SalesTerritory = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_StateProvinces(StateProvince entity)
		{
			this.SendPropertyChanging("StateProvinces");
			entity.SalesTerritory = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the CostLastYear field. Mapped on target field 'CostLastYear'. </summary>
		[Column(Name="CostLastYear", Storage="_costLastYear", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal CostLastYear
		{
			get	{ return _costLastYear; }
			set
			{
				if((_costLastYear != value))
				{
					OnCostLastYearChanging(value);
					SendPropertyChanging("CostLastYear");
					_costLastYear = value;
					SendPropertyChanged("CostLastYear");
					OnCostLastYearChanged();
				}
			}
		}

		/// <summary>Gets or sets the CostYtd field. Mapped on target field 'CostYTD'. </summary>
		[Column(Name="CostYTD", Storage="_costYtd", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal CostYtd
		{
			get	{ return _costYtd; }
			set
			{
				if((_costYtd != value))
				{
					OnCostYtdChanging(value);
					SendPropertyChanging("CostYtd");
					_costYtd = value;
					SendPropertyChanged("CostYtd");
					OnCostYtdChanged();
				}
			}
		}

		/// <summary>Gets or sets the CountryRegionCode field. Mapped on target field 'CountryRegionCode'. </summary>
		[Column(Name="CountryRegionCode", Storage="_countryRegionCode", CanBeNull=false, DbType="nvarchar(3) NOT NULL")]
		public System.String CountryRegionCode
		{
			get	{ return _countryRegionCode; }
			set
			{
				if((_countryRegionCode != value))
				{
					OnCountryRegionCodeChanging(value);
					SendPropertyChanging("CountryRegionCode");
					_countryRegionCode = value;
					SendPropertyChanged("CountryRegionCode");
					OnCountryRegionCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the Group field. Mapped on target field 'Group'. </summary>
		[Column(Name="Group", Storage="_group", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Group
		{
			get	{ return _group; }
			set
			{
				if((_group != value))
				{
					OnGroupChanging(value);
					SendPropertyChanging("Group");
					_group = value;
					SendPropertyChanged("Group");
					OnGroupChanged();
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

		/// <summary>Gets or sets the SalesLastYear field. Mapped on target field 'SalesLastYear'. </summary>
		[Column(Name="SalesLastYear", Storage="_salesLastYear", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal SalesLastYear
		{
			get	{ return _salesLastYear; }
			set
			{
				if((_salesLastYear != value))
				{
					OnSalesLastYearChanging(value);
					SendPropertyChanging("SalesLastYear");
					_salesLastYear = value;
					SendPropertyChanged("SalesLastYear");
					OnSalesLastYearChanged();
				}
			}
		}

		/// <summary>Gets or sets the SalesYtd field. Mapped on target field 'SalesYTD'. </summary>
		[Column(Name="SalesYTD", Storage="_salesYtd", CanBeNull=false, DbType="money NOT NULL")]
		public System.Decimal SalesYtd
		{
			get	{ return _salesYtd; }
			set
			{
				if((_salesYtd != value))
				{
					OnSalesYtdChanging(value);
					SendPropertyChanging("SalesYtd");
					_salesYtd = value;
					SendPropertyChanged("SalesYtd");
					OnSalesYtdChanged();
				}
			}
		}

		/// <summary>Gets or sets the TerritoryId field. Mapped on target field 'TerritoryID'. </summary>
		[Column(Name="TerritoryID", Storage="_territoryId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 TerritoryId
		{
			get	{ return _territoryId; }
			set
			{
				if((_territoryId != value))
				{
					OnTerritoryIdChanging(value);
					SendPropertyChanging("TerritoryId");
					_territoryId = value;
					SendPropertyChanged("TerritoryId");
					OnTerritoryIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Customer.SalesTerritory - SalesTerritory.Customers (m:1)'</summary>
		[Association(Name="Customer_SalesTerritoryb4b69480649448039aaca02f2725fea7", Storage="_customers", OtherKey="TerritoryId")]
		public EntitySet<Customer> Customers
		{
			get { return this._customers; }
			set { this._customers.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.SalesTerritory - SalesTerritory.SalesOrderHeaders (m:1)'</summary>
		[Association(Name="SalesOrderHeader_SalesTerritory44b37e7be3f647bbaf0db7376144a05b", Storage="_salesOrderHeaders", OtherKey="TerritoryId")]
		public EntitySet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return this._salesOrderHeaders; }
			set { this._salesOrderHeaders.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesPerson.SalesTerritory - SalesTerritory.SalesPeople (m:1)'</summary>
		[Association(Name="SalesPerson_SalesTerritoryf8210c025654468ab822c2fc043a1cfc", Storage="_salesPeople", OtherKey="TerritoryId")]
		public EntitySet<SalesPerson> SalesPeople
		{
			get { return this._salesPeople; }
			set { this._salesPeople.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTerritoryHistory.SalesTerritory - SalesTerritory.SalesTerritoryHistories (m:1)'</summary>
		[Association(Name="SalesTerritoryHistory_SalesTerritorye773e0f8bcbd41ce8572a8c1756f0e58", Storage="_salesTerritoryHistories", OtherKey="TerritoryId")]
		public EntitySet<SalesTerritoryHistory> SalesTerritoryHistories
		{
			get { return this._salesTerritoryHistories; }
			set { this._salesTerritoryHistories.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.SalesTerritory - SalesTerritory.StateProvinces (m:1)'</summary>
		[Association(Name="StateProvince_SalesTerritoryd468d9b5492d4f3b85bb98550b684afd", Storage="_stateProvinces", OtherKey="TerritoryId")]
		public EntitySet<StateProvince> StateProvinces
		{
			get { return this._stateProvinces; }
			set { this._stateProvinces.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649