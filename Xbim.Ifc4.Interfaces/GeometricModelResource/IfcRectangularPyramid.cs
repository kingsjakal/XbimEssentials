// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.GeometryResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.GeometricModelResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangularPyramid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangularPyramid : IIfcCsgPrimitive3D
	{
		IfcPositiveLengthMeasure @XLength { get; }
		IfcPositiveLengthMeasure @YLength { get; }
		IfcPositiveLengthMeasure @Height { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.GeometricModelResource
{
	[ExpressType("IFCRECTANGULARPYRAMID", 888)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangularPyramid : IfcCsgPrimitive3D, IInstantiableEntity, IIfcRectangularPyramid, IEqualityComparer<@IfcRectangularPyramid>, IEquatable<@IfcRectangularPyramid>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangularPyramid(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _xLength;
		private IfcPositiveLengthMeasure _yLength;
		private IfcPositiveLengthMeasure _height;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @XLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _xLength;
				((IPersistEntity)this).Activate(false);
				return _xLength;
			} 
			set
			{
				SetValue( v =>  _xLength = v, _xLength, value,  "XLength");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @YLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _yLength;
				((IPersistEntity)this).Activate(false);
				return _yLength;
			} 
			set
			{
				SetValue( v =>  _yLength = v, _yLength, value,  "YLength");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @Height 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _height;
				((IPersistEntity)this).Activate(false);
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
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
					_xLength = value.RealVal;
					return;
				case 2: 
					_yLength = value.RealVal;
					return;
				case 3: 
					_height = value.RealVal;
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
        public bool Equals(@IfcRectangularPyramid other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRectangularPyramid
            var root = (@IfcRectangularPyramid)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRectangularPyramid left, @IfcRectangularPyramid right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRectangularPyramid left, @IfcRectangularPyramid right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRectangularPyramid x, @IfcRectangularPyramid y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRectangularPyramid obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}