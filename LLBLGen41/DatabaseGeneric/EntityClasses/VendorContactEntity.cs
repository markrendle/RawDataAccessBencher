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
	
	/// <summary>Entity class which represents the entity 'VendorContact'.<br/><br/></summary>
	[Serializable]
	public partial class VendorContactEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private ContactEntity _contact;
		private ContactTypeEntity _contactType;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Contact</summary>
			public static readonly string Contact = "Contact";
			/// <summary>Member name ContactType</summary>
			public static readonly string ContactType = "ContactType";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VendorContactEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public VendorContactEntity():base("VendorContactEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VendorContactEntity(IEntityFields2 fields):base("VendorContactEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VendorContactEntity</param>
		public VendorContactEntity(IValidator validator):base("VendorContactEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="contactId">PK value for VendorContact which data should be fetched into this VendorContact object</param>
		/// <param name="vendorId">PK value for VendorContact which data should be fetched into this VendorContact object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public VendorContactEntity(System.Int32 contactId, System.Int32 vendorId):base("VendorContactEntity")
		{
			InitClassEmpty(null, null);
			this.ContactId = contactId;
			this.VendorId = vendorId;
		}

		/// <summary> CTor</summary>
		/// <param name="contactId">PK value for VendorContact which data should be fetched into this VendorContact object</param>
		/// <param name="vendorId">PK value for VendorContact which data should be fetched into this VendorContact object</param>
		/// <param name="validator">The custom validator object for this VendorContactEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public VendorContactEntity(System.Int32 contactId, System.Int32 vendorId, IValidator validator):base("VendorContactEntity")
		{
			InitClassEmpty(validator, null);
			this.ContactId = contactId;
			this.VendorId = vendorId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected VendorContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
				if(_contact!=null)
				{
					_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_contactType = (ContactTypeEntity)info.GetValue("_contactType", typeof(ContactTypeEntity));
				if(_contactType!=null)
				{
					_contactType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
				if(_vendor!=null)
				{
					_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((VendorContactFieldIndex)fieldIndex)
			{
				case VendorContactFieldIndex.ContactId:
					DesetupSyncContact(true, false);
					break;
				case VendorContactFieldIndex.ContactTypeId:
					DesetupSyncContactType(true, false);
					break;
				case VendorContactFieldIndex.VendorId:
					DesetupSyncVendor(true, false);
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
				case "Contact":
					this.Contact = (ContactEntity)entity;
					break;
				case "ContactType":
					this.ContactType = (ContactTypeEntity)entity;
					break;
				case "Vendor":
					this.Vendor = (VendorEntity)entity;
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
				case "Contact":
					toReturn.Add(Relations.ContactEntityUsingContactId);
					break;
				case "ContactType":
					toReturn.Add(Relations.ContactTypeEntityUsingContactTypeId);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorId);
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
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "ContactType":
					SetupSyncContactType(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false, true);
					break;
				case "ContactType":
					DesetupSyncContactType(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
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
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_contactType!=null)
			{
				toReturn.Add(_contactType);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
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
				info.AddValue("_contact", (!this.MarkedForDeletion?_contact:null));
				info.AddValue("_contactType", (!this.MarkedForDeletion?_contactType:null));
				info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new VendorContactRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Contact' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoContact()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ContactFields.ContactId, null, ComparisonOperator.Equal, this.ContactId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ContactType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoContactType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ContactTypeFields.ContactTypeId, null, ComparisonOperator.Equal, this.ContactTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(VendorFields.VendorId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(VendorContactEntityFactory));
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
			toReturn.Add("Contact", _contact);
			toReturn.Add("ContactType", _contactType);
			toReturn.Add("Vendor", _vendor);
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
			_fieldsCustomProperties.Add("ContactId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ContactTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VendorId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _contact</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContact(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.ContactEntityUsingContactIdStatic, true, signalRelatedEntity, "VendorContacts", resetFKFields, new int[] { (int)VendorContactFieldIndex.ContactId } );
			_contact = null;
		}

		/// <summary> setups the sync logic for member _contact</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntityCore relatedEntity)
		{
			if(_contact!=relatedEntity)
			{
				DesetupSyncContact(true, true);
				_contact = (ContactEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contact, new PropertyChangedEventHandler( OnContactPropertyChanged ), "Contact", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.ContactEntityUsingContactIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnContactPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _contactType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncContactType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _contactType, new PropertyChangedEventHandler( OnContactTypePropertyChanged ), "ContactType", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.ContactTypeEntityUsingContactTypeIdStatic, true, signalRelatedEntity, "VendorContacts", resetFKFields, new int[] { (int)VendorContactFieldIndex.ContactTypeId } );
			_contactType = null;
		}

		/// <summary> setups the sync logic for member _contactType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContactType(IEntityCore relatedEntity)
		{
			if(_contactType!=relatedEntity)
			{
				DesetupSyncContactType(true, true);
				_contactType = (ContactTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _contactType, new PropertyChangedEventHandler( OnContactTypePropertyChanged ), "ContactType", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.ContactTypeEntityUsingContactTypeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnContactTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.VendorEntityUsingVendorIdStatic, true, signalRelatedEntity, "VendorContacts", resetFKFields, new int[] { (int)VendorContactFieldIndex.VendorId } );
			_vendor = null;
		}

		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorContactRelations.VendorEntityUsingVendorIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this VendorContactEntity</param>
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
		public  static VendorContactRelations Relations
		{
			get	{ return new VendorContactRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Contact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathContact
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ContactEntityFactory))),	(IEntityRelation)GetRelationsForField("Contact")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorContactEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ContactEntity, 0, null, null, null, null, "Contact", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ContactType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathContactType
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ContactTypeEntityFactory))),	(IEntityRelation)GetRelationsForField("ContactType")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorContactEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ContactTypeEntity, 0, null, null, null, null, "ContactType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))),	(IEntityRelation)GetRelationsForField("Vendor")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorContactEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity, 0, null, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ContactId property of the Entity VendorContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VendorContact"."ContactID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ContactId
		{
			get { return (System.Int32)GetValue((int)VendorContactFieldIndex.ContactId, true); }
			set	{ SetValue((int)VendorContactFieldIndex.ContactId, value); }
		}

		/// <summary> The ContactTypeId property of the Entity VendorContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VendorContact"."ContactTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ContactTypeId
		{
			get { return (System.Int32)GetValue((int)VendorContactFieldIndex.ContactTypeId, true); }
			set	{ SetValue((int)VendorContactFieldIndex.ContactTypeId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity VendorContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VendorContact"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorContactFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The VendorId property of the Entity VendorContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "VendorContact"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorId
		{
			get { return (System.Int32)GetValue((int)VendorContactFieldIndex.VendorId, true); }
			set	{ SetValue((int)VendorContactFieldIndex.VendorId, value); }
		}

		/// <summary> Gets / sets related entity of type 'ContactEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get	{ return _contact; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorContacts", "Contact", _contact, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ContactTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ContactTypeEntity ContactType
		{
			get	{ return _contactType; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncContactType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorContacts", "ContactType", _contactType, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get	{ return _vendor; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "VendorContacts", "Vendor", _vendor, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorContactEntity; }
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
