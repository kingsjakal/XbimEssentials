// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.ExternalReferenceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcExternalReferenceRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcExternalReferenceRelationship : IIfcResourceLevelRelationship
	{
		IIfcExternalReference @RelatingReference { get; }
		IEnumerable<IfcResourceObjectSelect> @RelatedResourceObjects { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.ExternalReferenceResource
{
	[ExpressType("IFCEXTERNALREFERENCERELATIONSHIP", 634)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcExternalReferenceRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcExternalReferenceRelationship, IEqualityComparer<@IfcExternalReferenceRelationship>, IEquatable<@IfcExternalReferenceRelationship>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcExternalReferenceRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this, 0 );
		}

		#region Explicit attribute fields
		private IIfcExternalReference _relatingReference;
		private ItemSet<IfcResourceObjectSelect> _relatedResourceObjects;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcExternalReference @RelatingReference 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingReference;
				((IPersistEntity)this).Activate(false);
				return _relatingReference;
			} 
			set
			{
				SetValue( v =>  _relatingReference = v, _relatingReference, value,  "RelatingReference");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcResourceObjectSelect> @RelatedResourceObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedResourceObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedResourceObjects;
			} 
		}
		IEnumerable<IfcResourceObjectSelect> IIfcExternalReferenceRelationship.RelatedResourceObjects { get { return @RelatedResourceObjects; } }			 
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_relatingReference = (IIfcExternalReference)(value.EntityVal);
					return;
				case 3: 
					if (_relatedResourceObjects == null) _relatedResourceObjects = new ItemSet<IfcResourceObjectSelect>( this );
					_relatedResourceObjects.InternalAdd((IfcResourceObjectSelect)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcExternalReferenceRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcExternalReferenceRelationship
            var root = (@IfcExternalReferenceRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcExternalReferenceRelationship left, @IfcExternalReferenceRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcExternalReferenceRelationship left, @IfcExternalReferenceRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcExternalReferenceRelationship x, @IfcExternalReferenceRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcExternalReferenceRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}