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
using Xbim.Ifc4.Interfaces.PropertyResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcComplexProperty
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcComplexProperty : IIfcProperty
	{
		IfcIdentifier @UsageName { get; }
		IEnumerable<IIfcProperty> @HasProperties { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.PropertyResource
{
	[ExpressType("IFCCOMPLEXPROPERTY", 498)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexProperty : IfcProperty, IInstantiableEntity, IIfcComplexProperty, IEqualityComparer<@IfcComplexProperty>, IEquatable<@IfcComplexProperty>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexProperty(IModel model) : base(model) 		{ 
			Model = model; 
			_hasProperties = new ItemSet<IIfcProperty>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcIdentifier _usageName;
		private ItemSet<IIfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @UsageName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usageName;
				((IPersistEntity)this).Activate(false);
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IIfcProperty> @HasProperties 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasProperties;
				((IPersistEntity)this).Activate(false);
				return _hasProperties;
			} 
		}
		IEnumerable<IIfcProperty> IIfcComplexProperty.HasProperties { get { return @HasProperties; } }			 
	
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
					_usageName = value.StringVal;
					return;
				case 3: 
					if (_hasProperties == null) _hasProperties = new ItemSet<IIfcProperty>( this );
					_hasProperties.InternalAdd((IIfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : SIZEOF(QUERY(temp <* HasProperties | SELF :=: temp)) = 0;*/
		/*WR22:	WR22 : IfcUniquePropertyName(HasProperties);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcComplexProperty other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcComplexProperty
            var root = (@IfcComplexProperty)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcComplexProperty left, @IfcComplexProperty right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcComplexProperty left, @IfcComplexProperty right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcComplexProperty x, @IfcComplexProperty y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcComplexProperty obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}