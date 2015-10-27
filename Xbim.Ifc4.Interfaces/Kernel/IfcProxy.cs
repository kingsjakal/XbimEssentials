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
using Xbim.Ifc4.Interfaces.GeometricConstraintResource;
using Xbim.Ifc4.Interfaces.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProxy
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProxy : IIfcProduct
	{
		IfcObjectTypeEnum @ProxyType { get; }
		IfcLabel? @Tag { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.Kernel
{
	[ExpressType("IFCPROXY", 868)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProxy : IfcProduct, IInstantiableEntity, IIfcProxy, IEqualityComparer<@IfcProxy>, IEquatable<@IfcProxy>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProxy(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectTypeEnum _proxyType;
		private IfcLabel? _tag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcObjectTypeEnum @ProxyType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _proxyType;
				((IPersistEntity)this).Activate(false);
				return _proxyType;
			} 
			set
			{
				SetValue( v =>  _proxyType = v, _proxyType, value,  "ProxyType");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Tag 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _tag;
				((IPersistEntity)this).Activate(false);
				return _tag;
			} 
			set
			{
				SetValue( v =>  _tag = v, _tag, value,  "Tag");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
                    _proxyType = (IfcObjectTypeEnum) System.Enum.Parse(typeof (IfcObjectTypeEnum), value.EnumVal, true);
					return;
				case 8: 
					_tag = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : EXISTS(SELF\IfcRoot.Name);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProxy other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProxy
            var root = (@IfcProxy)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProxy left, @IfcProxy right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProxy left, @IfcProxy right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProxy x, @IfcProxy y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProxy obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}