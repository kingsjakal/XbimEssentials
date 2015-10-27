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
using Xbim.Ifc4.Interfaces.ActorResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPostalAddress
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPostalAddress : IIfcAddress
	{
		IfcLabel? @InternalLocation { get; }
		IEnumerable<IfcLabel> @AddressLines { get; }
		IfcLabel? @PostalBox { get; }
		IfcLabel? @Town { get; }
		IfcLabel? @Region { get; }
		IfcLabel? @PostalCode { get; }
		IfcLabel? @Country { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.ActorResource
{
	[ExpressType("IFCPOSTALADDRESS", 823)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPostalAddress : IfcAddress, IInstantiableEntity, IIfcPostalAddress, IEqualityComparer<@IfcPostalAddress>, IEquatable<@IfcPostalAddress>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPostalAddress(IModel model) : base(model) 		{ 
			Model = model; 
			_addressLines = new OptionalItemSet<IfcLabel>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _internalLocation;
		private OptionalItemSet<IfcLabel> _addressLines;
		private IfcLabel? _postalBox;
		private IfcLabel? _town;
		private IfcLabel? _region;
		private IfcLabel? _postalCode;
		private IfcLabel? _country;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @InternalLocation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _internalLocation;
				((IPersistEntity)this).Activate(false);
				return _internalLocation;
			} 
			set
			{
				SetValue( v =>  _internalLocation = v, _internalLocation, value,  "InternalLocation");
			} 
		}
	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 1, -1)]
		public OptionalItemSet<IfcLabel> @AddressLines 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _addressLines;
				((IPersistEntity)this).Activate(false);
				return _addressLines;
			} 
		}
		IEnumerable<IfcLabel> IIfcPostalAddress.AddressLines { get { return @AddressLines; } }			 
	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @PostalBox 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _postalBox;
				((IPersistEntity)this).Activate(false);
				return _postalBox;
			} 
			set
			{
				SetValue( v =>  _postalBox = v, _postalBox, value,  "PostalBox");
			} 
		}
	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Town 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _town;
				((IPersistEntity)this).Activate(false);
				return _town;
			} 
			set
			{
				SetValue( v =>  _town = v, _town, value,  "Town");
			} 
		}
	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Region 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _region;
				((IPersistEntity)this).Activate(false);
				return _region;
			} 
			set
			{
				SetValue( v =>  _region = v, _region, value,  "Region");
			} 
		}
	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @PostalCode 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _postalCode;
				((IPersistEntity)this).Activate(false);
				return _postalCode;
			} 
			set
			{
				SetValue( v =>  _postalCode = v, _postalCode, value,  "PostalCode");
			} 
		}
	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Country 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _country;
				((IPersistEntity)this).Activate(false);
				return _country;
			} 
			set
			{
				SetValue( v =>  _country = v, _country, value,  "Country");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_internalLocation = value.StringVal;
					return;
				case 4: 
					if (_addressLines == null) _addressLines = new OptionalItemSet<IfcLabel>( this );
					_addressLines.InternalAdd(value.StringVal);
					return;
				case 5: 
					_postalBox = value.StringVal;
					return;
				case 6: 
					_town = value.StringVal;
					return;
				case 7: 
					_region = value.StringVal;
					return;
				case 8: 
					_postalCode = value.StringVal;
					return;
				case 9: 
					_country = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:            EXISTS (Country);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPostalAddress other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPostalAddress
            var root = (@IfcPostalAddress)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPostalAddress left, @IfcPostalAddress right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPostalAddress left, @IfcPostalAddress right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPostalAddress x, @IfcPostalAddress y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPostalAddress obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}