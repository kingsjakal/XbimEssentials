// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.MeasureResource;
using Xbim.Ifc4.Interfaces.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.ProfileResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcArbitraryOpenProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcArbitraryOpenProfileDef : IIfcProfileDef
	{
		IIfcBoundedCurve @Curve { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.ProfileResource
{
	[ExpressType("IFCARBITRARYOPENPROFILEDEF", 415)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcArbitraryOpenProfileDef : IfcProfileDef, IInstantiableEntity, IIfcArbitraryOpenProfileDef, IEqualityComparer<@IfcArbitraryOpenProfileDef>, IEquatable<@IfcArbitraryOpenProfileDef>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcArbitraryOpenProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IIfcBoundedCurve _curve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcBoundedCurve @Curve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _curve;
				((IPersistEntity)this).Activate(false);
				return _curve;
			} 
			set
			{
				SetValue( v =>  _curve = v, _curve, value,  "Curve");
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
					_curve = (IIfcBoundedCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR11:              (SELF\IfcProfileDef.ProfileType = IfcProfileTypeEnum.CURVE);*/
		/*WR12:	WR12 : Curve.Dim = 2;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcArbitraryOpenProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcArbitraryOpenProfileDef
            var root = (@IfcArbitraryOpenProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcArbitraryOpenProfileDef left, @IfcArbitraryOpenProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcArbitraryOpenProfileDef left, @IfcArbitraryOpenProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcArbitraryOpenProfileDef x, @IfcArbitraryOpenProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcArbitraryOpenProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}