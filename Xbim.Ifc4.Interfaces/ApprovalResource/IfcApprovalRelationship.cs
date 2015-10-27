// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces.ExternalReferenceResource;
using Xbim.Ifc4.Interfaces.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces.ApprovalResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApprovalRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApprovalRelationship : IIfcResourceLevelRelationship
	{
		IIfcApproval @RelatingApproval { get; }
		IEnumerable<IIfcApproval> @RelatedApprovals { get; }
	}
}

namespace Xbim.Ifc4.Interfaces.ApprovalResource
{
	[IndexedClass]
	[ExpressType("IFCAPPROVALRELATIONSHIP", 413)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalRelationship : IfcResourceLevelRelationship, IInstantiableEntity, IIfcApprovalRelationship, IEqualityComparer<@IfcApprovalRelationship>, IEquatable<@IfcApprovalRelationship>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalRelationship(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedApprovals = new ItemSet<IIfcApproval>( this, 0 );
		}

		#region Explicit attribute fields
		private IIfcApproval _relatingApproval;
		private ItemSet<IIfcApproval> _relatedApprovals;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IIfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingApproval;
				((IPersistEntity)this).Activate(false);
				return _relatingApproval;
			} 
			set
			{
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval");
			} 
		}
	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IIfcApproval> @RelatedApprovals 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedApprovals;
				((IPersistEntity)this).Activate(false);
				return _relatedApprovals;
			} 
		}
		IEnumerable<IIfcApproval> IIfcApprovalRelationship.RelatedApprovals { get { return @RelatedApprovals; } }			 
	
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
					_relatingApproval = (IIfcApproval)(value.EntityVal);
					return;
				case 3: 
					if (_relatedApprovals == null) _relatedApprovals = new ItemSet<IIfcApproval>( this );
					_relatedApprovals.InternalAdd((IIfcApproval)value.EntityVal);
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
        public bool Equals(@IfcApprovalRelationship other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcApprovalRelationship
            var root = (@IfcApprovalRelationship)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcApprovalRelationship left, @IfcApprovalRelationship right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcApprovalRelationship left, @IfcApprovalRelationship right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcApprovalRelationship x, @IfcApprovalRelationship y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcApprovalRelationship obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}