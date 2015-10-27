// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.ProductExtension;
using Xbim.Ifc4.Interfaces.UtilityResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using Xbim.Ifc4.Interfaces.GeometricConstraintResource;
using Xbim.Ifc4.Interfaces.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.SharedBldgServiceElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDistributionControlElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionControlElement : IIfcDistributionElement
	{
	}
}

namespace Xbim.Ifc4.Interfaces.SharedBldgServiceElements
{
	[ExpressType("IFCDISTRIBUTIONCONTROLELEMENT", 570)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionControlElement : IfcDistributionElement, IInstantiableEntity, IIfcDistributionControlElement, IEqualityComparer<@IfcDistributionControlElement>, IEquatable<@IfcDistributionControlElement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionControlElement(IModel model) : base(model) 		{ 
			Model = model; 
		}


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelFlowControlElements> @AssignedToFlowElement 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelFlowControlElements>(e => e.RelatedControlElements != null &&  e.RelatedControlElements.Contains(this));
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
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
        public bool Equals(@IfcDistributionControlElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDistributionControlElement
            var root = (@IfcDistributionControlElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDistributionControlElement left, @IfcDistributionControlElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDistributionControlElement left, @IfcDistributionControlElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDistributionControlElement x, @IfcDistributionControlElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDistributionControlElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}