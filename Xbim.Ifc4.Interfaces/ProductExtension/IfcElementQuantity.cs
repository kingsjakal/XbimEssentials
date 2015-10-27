// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.Kernel;
using Xbim.Ifc4.Interfaces.UtilityResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using Xbim.Ifc4.Interfaces.QuantityResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElementQuantity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElementQuantity : IIfcQuantitySet
	{
		IfcLabel? @MethodOfMeasurement { get; }
		IEnumerable<IIfcPhysicalQuantity> @Quantities { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.ProductExtension
{
	[ExpressType("IFCELEMENTQUANTITY", 615)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcElementQuantity : IfcQuantitySet, IInstantiableEntity, IIfcElementQuantity, IEqualityComparer<@IfcElementQuantity>, IEquatable<@IfcElementQuantity>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementQuantity(IModel model) : base(model) 		{ 
			Model = model; 
			_quantities = new ItemSet<IIfcPhysicalQuantity>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _methodOfMeasurement;
		private ItemSet<IIfcPhysicalQuantity> _quantities;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @MethodOfMeasurement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _methodOfMeasurement;
				((IPersistEntity)this).Activate(false);
				return _methodOfMeasurement;
			} 
			set
			{
				SetValue( v =>  _methodOfMeasurement = v, _methodOfMeasurement, value,  "MethodOfMeasurement");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IIfcPhysicalQuantity> @Quantities 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _quantities;
				((IPersistEntity)this).Activate(false);
				return _quantities;
			} 
		}
		IEnumerable<IIfcPhysicalQuantity> IIfcElementQuantity.Quantities { get { return @Quantities; } }			 
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_methodOfMeasurement = value.StringVal;
					return;
				case 5: 
					if (_quantities == null) _quantities = new ItemSet<IIfcPhysicalQuantity>( this );
					_quantities.InternalAdd((IIfcPhysicalQuantity)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UniqueQuantityNames:	UniqueQuantityNames : IfcUniqueQuantityNames(Quantities);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElementQuantity other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcElementQuantity
            var root = (@IfcElementQuantity)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcElementQuantity left, @IfcElementQuantity right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcElementQuantity left, @IfcElementQuantity right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcElementQuantity x, @IfcElementQuantity y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcElementQuantity obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}