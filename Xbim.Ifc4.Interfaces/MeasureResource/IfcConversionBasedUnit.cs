// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.ExternalReferenceResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.MeasureResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcConversionBasedUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConversionBasedUnit : IIfcNamedUnit, IfcResourceObjectSelect
	{
		IfcLabel @Name { get; }
		IIfcMeasureWithUnit @ConversionFactor { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.MeasureResource
{
	[ExpressType("IFCCONVERSIONBASEDUNIT", 530)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConversionBasedUnit : IfcNamedUnit, IInstantiableEntity, IIfcConversionBasedUnit, IEqualityComparer<@IfcConversionBasedUnit>, IEquatable<@IfcConversionBasedUnit>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConversionBasedUnit(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IIfcMeasureWithUnit _conversionFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcMeasureWithUnit @ConversionFactor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _conversionFactor;
				((IPersistEntity)this).Activate(false);
				return _conversionFactor;
			} 
			set
			{
				SetValue( v =>  _conversionFactor = v, _conversionFactor, value,  "ConversionFactor");
			} 
		}
	
		#endregion

		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcExternalReferenceRelationship> @HasExternalReference 
		{ 
			get 
			{
				return Model.Instances.Where<IfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
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
					_name = value.StringVal;
					return;
				case 3: 
					_conversionFactor = (IIfcMeasureWithUnit)(value.EntityVal);
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
        public bool Equals(@IfcConversionBasedUnit other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConversionBasedUnit
            var root = (@IfcConversionBasedUnit)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConversionBasedUnit left, @IfcConversionBasedUnit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConversionBasedUnit left, @IfcConversionBasedUnit right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConversionBasedUnit x, @IfcConversionBasedUnit y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConversionBasedUnit obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}