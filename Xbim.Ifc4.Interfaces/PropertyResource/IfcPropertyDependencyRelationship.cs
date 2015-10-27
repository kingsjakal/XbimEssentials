// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.ExternalReferenceResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.PropertyResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyDependencyRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyDependencyRelationship : IIfcResourceLevelRelationship
	{
		IIfcProperty @DependingProperty { get; }
		IIfcProperty @DependantProperty { get; }
		IfcText? @Expression { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.PropertyResource
{
	[IndexedClass]
	[ExpressType("IFCPROPERTYDEPENDENCYRELATIONSHIP", 852)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyDependencyRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcPropertyDependencyRelationship, IEqualityComparer<@IfcPropertyDependencyRelationship>, IEquatable<@IfcPropertyDependencyRelationship>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyDependencyRelationship(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IIfcProperty _dependingProperty;
		private IIfcProperty _dependantProperty;
		private IfcText? _expression;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcProperty @DependingProperty 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dependingProperty;
				((IPersistEntity)this).Activate(false);
				return _dependingProperty;
			} 
			set
			{
				SetValue( v =>  _dependingProperty = v, _dependingProperty, value,  "DependingProperty");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcProperty @DependantProperty 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _dependantProperty;
				((IPersistEntity)this).Activate(false);
				return _dependantProperty;
			} 
			set
			{
				SetValue( v =>  _dependantProperty = v, _dependantProperty, value,  "DependantProperty");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Expression 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _expression;
				((IPersistEntity)this).Activate(false);
				return _expression;
			} 
			set
			{
				SetValue( v =>  _expression = v, _expression, value,  "Expression");
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
					_dependingProperty = (IIfcProperty)(value.EntityVal);
					return;
				case 3: 
					_dependantProperty = (IIfcProperty)(value.EntityVal);
					return;
				case 4: 
					_expression = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : DependingProperty :<>: DependantProperty;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyDependencyRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyDependencyRelationship
            var root = (@IfcPropertyDependencyRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyDependencyRelationship left, @IfcPropertyDependencyRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyDependencyRelationship left, @IfcPropertyDependencyRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyDependencyRelationship x, @IfcPropertyDependencyRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyDependencyRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}