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
using Xbim.Ifc4.Interfaces.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRectangularTrimmedSurface
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRectangularTrimmedSurface : IIfcBoundedSurface
	{
		IIfcSurface @BasisSurface { get; }
		IfcParameterValue @U1 { get; }
		IfcParameterValue @V1 { get; }
		IfcParameterValue @U2 { get; }
		IfcParameterValue @V2 { get; }
		bool @Usense { get; }
		bool @Vsense { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.GeometryResource
{
	[ExpressType("IFCRECTANGULARTRIMMEDSURFACE", 889)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRectangularTrimmedSurface : IfcBoundedSurface, IInstantiableEntity, IIfcRectangularTrimmedSurface, IEqualityComparer<@IfcRectangularTrimmedSurface>, IEquatable<@IfcRectangularTrimmedSurface>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRectangularTrimmedSurface(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IIfcSurface _basisSurface;
		private IfcParameterValue _u1;
		private IfcParameterValue _v1;
		private IfcParameterValue _u2;
		private IfcParameterValue _v2;
		private bool _usense;
		private bool _vsense;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcSurface @BasisSurface 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _basisSurface;
				((IPersistEntity)this).Activate(false);
				return _basisSurface;
			} 
			set
			{
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface");
			} 
		}
	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @U1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _u1;
				((IPersistEntity)this).Activate(false);
				return _u1;
			} 
			set
			{
				SetValue( v =>  _u1 = v, _u1, value,  "U1");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @V1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _v1;
				((IPersistEntity)this).Activate(false);
				return _v1;
			} 
			set
			{
				SetValue( v =>  _v1 = v, _v1, value,  "V1");
			} 
		}
	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @U2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _u2;
				((IPersistEntity)this).Activate(false);
				return _u2;
			} 
			set
			{
				SetValue( v =>  _u2 = v, _u2, value,  "U2");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcParameterValue @V2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _v2;
				((IPersistEntity)this).Activate(false);
				return _v2;
			} 
			set
			{
				SetValue( v =>  _v2 = v, _v2, value,  "V2");
			} 
		}
	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Usense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usense;
				((IPersistEntity)this).Activate(false);
				return _usense;
			} 
			set
			{
				SetValue( v =>  _usense = v, _usense, value,  "Usense");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @Vsense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _vsense;
				((IPersistEntity)this).Activate(false);
				return _vsense;
			} 
			set
			{
				SetValue( v =>  _vsense = v, _vsense, value,  "Vsense");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_basisSurface = (IIfcSurface)(value.EntityVal);
					return;
				case 1: 
					_u1 = value.RealVal;
					return;
				case 2: 
					_v1 = value.RealVal;
					return;
				case 3: 
					_u2 = value.RealVal;
					return;
				case 4: 
					_v2 = value.RealVal;
					return;
				case 5: 
					_usense = value.BooleanVal;
					return;
				case 6: 
					_vsense = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*U1AndU2Different:	U1AndU2Different : U1 <> U2;*/
		/*V1AndV2Different:	V1AndV2Different : V1 <> V2;*/
		/*UsenseCompatible:                                  (Usense = (U2 > U1));*/
		/*VsenseCompatible:	VsenseCompatible : Vsense = (V2 > V1);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRectangularTrimmedSurface other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRectangularTrimmedSurface
            var root = (@IfcRectangularTrimmedSurface)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRectangularTrimmedSurface left, @IfcRectangularTrimmedSurface right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRectangularTrimmedSurface left, @IfcRectangularTrimmedSurface right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRectangularTrimmedSurface x, @IfcRectangularTrimmedSurface y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRectangularTrimmedSurface obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}