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
	/// <summary>Class which represents the entity 'Illustration', mapped on table 'AdventureWorks.Production.Illustration'.</summary>
	[Table(Name="[Production].[Illustration]")]
	public partial class Illustration : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_diagram;
		private System.Int32	_illustrationId;
		private System.DateTime	_modifiedDate;
		private EntitySet <ProductModelIllustration> _productModelIllustrations;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnDiagramChanging(System.String value);
		partial void OnDiagramChanged();
		partial void OnIllustrationIdChanging(System.Int32 value);
		partial void OnIllustrationIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Illustration"/> class.</summary>
		public Illustration()
		{
			_productModelIllustrations = new EntitySet<ProductModelIllustration>(new Action<ProductModelIllustration>(this.Attach_ProductModelIllustrations), new Action<ProductModelIllustration>(this.Detach_ProductModelIllustrations) );
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
		private void Attach_ProductModelIllustrations(ProductModelIllustration entity)
		{
			this.SendPropertyChanging("ProductModelIllustrations");
			entity.Illustration = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_ProductModelIllustrations(ProductModelIllustration entity)
		{
			this.SendPropertyChanging("ProductModelIllustrations");
			entity.Illustration = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the Diagram field. Mapped on target field 'Diagram'. </summary>
		[Column(Name="Diagram", Storage="_diagram", DbType="xml NULL", UpdateCheck=UpdateCheck.Never)]
		public System.String Diagram
		{
			get	{ return _diagram; }
			set
			{
				if((_diagram != value))
				{
					OnDiagramChanging(value);
					SendPropertyChanging("Diagram");
					_diagram = value;
					SendPropertyChanged("Diagram");
					OnDiagramChanged();
				}
			}
		}

		/// <summary>Gets or sets the IllustrationId field. Mapped on target field 'IllustrationID'. </summary>
		[Column(Name="IllustrationID", Storage="_illustrationId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 IllustrationId
		{
			get	{ return _illustrationId; }
			set
			{
				if((_illustrationId != value))
				{
					OnIllustrationIdChanging(value);
					SendPropertyChanging("IllustrationId");
					_illustrationId = value;
					SendPropertyChanged("IllustrationId");
					OnIllustrationIdChanged();
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

		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelIllustration.Illustration - Illustration.ProductModelIllustrations (m:1)'</summary>
		[Association(Name="ProductModelIllustration_Illustrationf1153741ae8642d8a68d72f4c6692a56", Storage="_productModelIllustrations", OtherKey="IllustrationId")]
		public EntitySet<ProductModelIllustration> ProductModelIllustrations
		{
			get { return this._productModelIllustrations; }
			set { this._productModelIllustrations.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649