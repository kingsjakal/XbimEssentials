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
using Xbim.Ifc4.Interfaces.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureCoordinateGenerator
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureCoordinateGenerator : IIfcTextureCoordinate
	{
		IfcLabel @Mode { get; }
		IEnumerable<IfcReal> @Parameter { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.PresentationAppearanceResource
{
	[ExpressType("IFCTEXTURECOORDINATEGENERATOR", 1099)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureCoordinateGenerator : IfcTextureCoordinate, IInstantiableEntity, IIfcTextureCoordinateGenerator, IEqualityComparer<@IfcTextureCoordinateGenerator>, IEquatable<@IfcTextureCoordinateGenerator>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinateGenerator(IModel model) : base(model) 		{ 
			Model = model; 
			_parameter = new OptionalItemSet<IfcReal>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel _mode;
		private OptionalItemSet<IfcReal> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel @Mode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mode;
				((IPersistEntity)this).Activate(false);
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode");
			} 
		}
	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcReal> @Parameter 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parameter;
				((IPersistEntity)this).Activate(false);
				return _parameter;
			} 
		}
		IEnumerable<IfcReal> IIfcTextureCoordinateGenerator.Parameter { get { return @Parameter; } }			 
	
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
					_mode = value.StringVal;
					return;
				case 2: 
					if (_parameter == null) _parameter = new OptionalItemSet<IfcReal>( this );
					_parameter.InternalAdd(value.RealVal);
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
        public bool Equals(@IfcTextureCoordinateGenerator other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureCoordinateGenerator
            var root = (@IfcTextureCoordinateGenerator)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureCoordinateGenerator left, @IfcTextureCoordinateGenerator right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureCoordinateGenerator left, @IfcTextureCoordinateGenerator right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextureCoordinateGenerator x, @IfcTextureCoordinateGenerator y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextureCoordinateGenerator obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}