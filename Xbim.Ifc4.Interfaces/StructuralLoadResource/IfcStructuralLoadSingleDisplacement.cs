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
using Xbim.Ifc4.Interfaces.StructuralLoadResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadSingleDisplacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadSingleDisplacement : IIfcStructuralLoadStatic
	{
		IfcLengthMeasure? @DisplacementX { get; }
		IfcLengthMeasure? @DisplacementY { get; }
		IfcLengthMeasure? @DisplacementZ { get; }
		IfcPlaneAngleMeasure? @RotationalDisplacementRX { get; }
		IfcPlaneAngleMeasure? @RotationalDisplacementRY { get; }
		IfcPlaneAngleMeasure? @RotationalDisplacementRZ { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADSINGLEDISPLACEMENT", 1029)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadSingleDisplacement, IEqualityComparer<@IfcStructuralLoadSingleDisplacement>, IEquatable<@IfcStructuralLoadSingleDisplacement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleDisplacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _displacementX;
		private IfcLengthMeasure? _displacementY;
		private IfcLengthMeasure? _displacementZ;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRX;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRY;
		private IfcPlaneAngleMeasure? _rotationalDisplacementRZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _displacementX;
				((IPersistEntity)this).Activate(false);
				return _displacementX;
			} 
			set
			{
				SetValue( v =>  _displacementX = v, _displacementX, value,  "DisplacementX");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _displacementY;
				((IPersistEntity)this).Activate(false);
				return _displacementY;
			} 
			set
			{
				SetValue( v =>  _displacementY = v, _displacementY, value,  "DisplacementY");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @DisplacementZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _displacementZ;
				((IPersistEntity)this).Activate(false);
				return _displacementZ;
			} 
			set
			{
				SetValue( v =>  _displacementZ = v, _displacementZ, value,  "DisplacementZ");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRX 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalDisplacementRX;
				((IPersistEntity)this).Activate(false);
				return _rotationalDisplacementRX;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRX = v, _rotationalDisplacementRX, value,  "RotationalDisplacementRX");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalDisplacementRY;
				((IPersistEntity)this).Activate(false);
				return _rotationalDisplacementRY;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRY = v, _rotationalDisplacementRY, value,  "RotationalDisplacementRY");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPlaneAngleMeasure? @RotationalDisplacementRZ 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _rotationalDisplacementRZ;
				((IPersistEntity)this).Activate(false);
				return _rotationalDisplacementRZ;
			} 
			set
			{
				SetValue( v =>  _rotationalDisplacementRZ = v, _rotationalDisplacementRZ, value,  "RotationalDisplacementRZ");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_displacementX = value.RealVal;
					return;
				case 2: 
					_displacementY = value.RealVal;
					return;
				case 3: 
					_displacementZ = value.RealVal;
					return;
				case 4: 
					_rotationalDisplacementRX = value.RealVal;
					return;
				case 5: 
					_rotationalDisplacementRY = value.RealVal;
					return;
				case 6: 
					_rotationalDisplacementRZ = value.RealVal;
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
        public bool Equals(@IfcStructuralLoadSingleDisplacement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadSingleDisplacement
            var root = (@IfcStructuralLoadSingleDisplacement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadSingleDisplacement left, @IfcStructuralLoadSingleDisplacement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadSingleDisplacement left, @IfcStructuralLoadSingleDisplacement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadSingleDisplacement x, @IfcStructuralLoadSingleDisplacement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadSingleDisplacement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}