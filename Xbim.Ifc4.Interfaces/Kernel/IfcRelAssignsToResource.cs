// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.UtilityResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsToResource
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToResource : IIfcRelAssigns
	{
		IfcResourceSelect @RelatingResource { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.Kernel
{
	[ExpressType("IFCRELASSIGNSTORESOURCE", 909)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToResource : IfcRelAssigns, IInstantiableEntity, IIfcRelAssignsToResource, IEqualityComparer<@IfcRelAssignsToResource>, IEquatable<@IfcRelAssignsToResource>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToResource(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcResourceSelect _relatingResource;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcResourceSelect @RelatingResource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingResource;
				((IPersistEntity)this).Activate(false);
				return _relatingResource;
			} 
			set
			{
				SetValue( v =>  _relatingResource = v, _relatingResource, value,  "RelatingResource");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_relatingResource = (IfcResourceSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingResource :=: Temp)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToResource other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssignsToResource
            var root = (@IfcRelAssignsToResource)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssignsToResource left, @IfcRelAssignsToResource right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssignsToResource left, @IfcRelAssignsToResource right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssignsToResource x, @IfcRelAssignsToResource y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssignsToResource obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}