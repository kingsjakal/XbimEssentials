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
    /// Readonly interface for IfcRelAssignsToProcess
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToProcess : IIfcRelAssigns
	{
		IfcProcessSelect @RelatingProcess { get; }
		IIfcMeasureWithUnit @QuantityInProcess { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.Kernel
{
	[ExpressType("IFCRELASSIGNSTOPROCESS", 907)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToProcess : IfcRelAssigns, IInstantiableEntity, IIfcRelAssignsToProcess, IEqualityComparer<@IfcRelAssignsToProcess>, IEquatable<@IfcRelAssignsToProcess>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProcessSelect _relatingProcess;
		private IIfcMeasureWithUnit _quantityInProcess;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcessSelect @RelatingProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingProcess;
				((IPersistEntity)this).Activate(false);
				return _relatingProcess;
			} 
			set
			{
				SetValue( v =>  _relatingProcess = v, _relatingProcess, value,  "RelatingProcess");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcMeasureWithUnit @QuantityInProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _quantityInProcess;
				((IPersistEntity)this).Activate(false);
				return _quantityInProcess;
			} 
			set
			{
				SetValue( v =>  _quantityInProcess = v, _quantityInProcess, value,  "QuantityInProcess");
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
					_relatingProcess = (IfcProcessSelect)(value.EntityVal);
					return;
				case 7: 
					_quantityInProcess = (IIfcMeasureWithUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(Temp <* SELF\IfcRelAssigns.RelatedObjects | RelatingProcess :=: Temp)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToProcess other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssignsToProcess
            var root = (@IfcRelAssignsToProcess)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssignsToProcess left, @IfcRelAssignsToProcess right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssignsToProcess left, @IfcRelAssignsToProcess right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelAssignsToProcess x, @IfcRelAssignsToProcess y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelAssignsToProcess obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}