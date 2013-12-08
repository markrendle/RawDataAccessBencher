﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using AdventureWorks.Dal.Adapter.v41.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'BillOfMaterial'.<br/><br/></summary>
	[Serializable]
	public partial class BillOfMaterialEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private ProductEntity _product;
		private ProductEntity _product_;
		private UnitMeasureEntity _unitMeasure;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name Product_</summary>
			public static readonly string Product_ = "Product_";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BillOfMaterialEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public BillOfMaterialEntity():base("BillOfMaterialEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BillOfMaterialEntity(IEntityFields2 fields):base("BillOfMaterialEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BillOfMaterialEntity</param>
		public BillOfMaterialEntity(IValidator validator):base("BillOfMaterialEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="billOfMaterialsId">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsId):base("BillOfMaterialEntity")
		{
			InitClassEmpty(null, null);
			this.BillOfMaterialsId = billOfMaterialsId;
		}

		/// <summary> CTor</summary>
		/// <param name="billOfMaterialsId">PK value for BillOfMaterial which data should be fetched into this BillOfMaterial object</param>
		/// <param name="validator">The custom validator object for this BillOfMaterialEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BillOfMaterialEntity(System.Int32 billOfMaterialsId, IValidator validator):base("BillOfMaterialEntity")
		{
			InitClassEmpty(validator, null);
			this.BillOfMaterialsId = billOfMaterialsId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected BillOfMaterialEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
				if(_product!=null)
				{
					_product.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_product_ = (ProductEntity)info.GetValue("_product_", typeof(ProductEntity));
				if(_product_!=null)
				{
					_product_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
				if(_unitMeasure!=null)
				{
					_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((BillOfMaterialFieldIndex)fieldIndex)
			{
				case BillOfMaterialFieldIndex.ComponentId:
					DesetupSyncProduct(true, false);
					break;
				case BillOfMaterialFieldIndex.ProductAssemblyId:
					DesetupSyncProduct_(true, false);
					break;
				case BillOfMaterialFieldIndex.UnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Product":
					this.Product = (ProductEntity)entity;
					break;
				case "Product_":
					this.Product_ = (ProductEntity)entity;
					break;
				case "UnitMeasure":
					this.UnitMeasure = (UnitMeasureEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Product":
					toReturn.Add(Relations.ProductEntityUsingComponentId);
					break;
				case "Product_":
					toReturn.Add(Relations.ProductEntityUsingProductAssemblyId);
					break;
				case "UnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingUnitMeasureCode);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "Product_":
					SetupSyncProduct_(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Product":
					DesetupSyncProduct(false, true);
					break;
				case "Product_":
					DesetupSyncProduct_(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			if(_product_!=null)
			{
				toReturn.Add(_product_);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
				info.AddValue("_product_", (!this.MarkedForDeletion?_product_:null));
				info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new BillOfMaterialRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ComponentId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductAssemblyId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.UnitMeasureCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("Product_", _product_);
			toReturn.Add("UnitMeasure", _unitMeasure);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BillOfMaterialsId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Bomlevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ComponentId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PerAssemblyQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductAssemblyId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingComponentIdStatic, true, signalRelatedEntity, "BillOfMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ComponentId } );
			_product = null;
		}

		/// <summary> setups the sync logic for member _product</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntityCore relatedEntity)
		{
			if(_product!=relatedEntity)
			{
				DesetupSyncProduct(true, true);
				_product = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingComponentIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _product_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct_(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product_, new PropertyChangedEventHandler( OnProduct_PropertyChanged ), "Product_", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingProductAssemblyIdStatic, true, signalRelatedEntity, "BillOfMaterials_", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.ProductAssemblyId } );
			_product_ = null;
		}

		/// <summary> setups the sync logic for member _product_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct_(IEntityCore relatedEntity)
		{
			if(_product_!=relatedEntity)
			{
				DesetupSyncProduct_(true, true);
				_product_ = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product_, new PropertyChangedEventHandler( OnProduct_PropertyChanged ), "Product_", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.ProductEntityUsingProductAssemblyIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProduct_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.UnitMeasureEntityUsingUnitMeasureCodeStatic, true, signalRelatedEntity, "BillOfMaterials", resetFKFields, new int[] { (int)BillOfMaterialFieldIndex.UnitMeasureCode } );
			_unitMeasure = null;
		}

		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntityCore relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticBillOfMaterialRelations.UnitMeasureEntityUsingUnitMeasureCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BillOfMaterialEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static BillOfMaterialRelations Relations
		{
			get	{ return new BillOfMaterialRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))),	(IEntityRelation)GetRelationsForField("Product")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ProductEntity, 0, null, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct_
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))),	(IEntityRelation)GetRelationsForField("Product_")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ProductEntity, 0, null, null, null, null, "Product_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))),	(IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.UnitMeasureEntity, 0, null, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The BillOfMaterialsId property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BillOfMaterialsID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 BillOfMaterialsId
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsId, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.BillOfMaterialsId, value); }
		}

		/// <summary> The Bomlevel property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."BOMLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Bomlevel
		{
			get { return (System.Int16)GetValue((int)BillOfMaterialFieldIndex.Bomlevel, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.Bomlevel, value); }
		}

		/// <summary> The ComponentId property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ComponentID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ComponentId
		{
			get { return (System.Int32)GetValue((int)BillOfMaterialFieldIndex.ComponentId, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ComponentId, value); }
		}

		/// <summary> The EndDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."EndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)BillOfMaterialFieldIndex.EndDate, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.EndDate, value); }
		}

		/// <summary> The ModifiedDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The PerAssemblyQty property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."PerAssemblyQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PerAssemblyQty
		{
			get { return (System.Decimal)GetValue((int)BillOfMaterialFieldIndex.PerAssemblyQty, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.PerAssemblyQty, value); }
		}

		/// <summary> The ProductAssemblyId property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."ProductAssemblyID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductAssemblyId
		{
			get { return (Nullable<System.Int32>)GetValue((int)BillOfMaterialFieldIndex.ProductAssemblyId, false); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.ProductAssemblyId, value); }
		}

		/// <summary> The StartDate property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."StartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)BillOfMaterialFieldIndex.StartDate, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.StartDate, value); }
		}

		/// <summary> The UnitMeasureCode property of the Entity BillOfMaterial<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BillOfMaterials"."UnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)BillOfMaterialFieldIndex.UnitMeasureCode, value); }
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return _product; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials", "Product", _product, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product_
		{
			get	{ return _product_; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProduct_(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials_", "Product_", _product_, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return _unitMeasure; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BillOfMaterials", "UnitMeasure", _unitMeasure, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v41.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
