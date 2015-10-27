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
using Xbim.Ifc4.Interfaces.RepresentationResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTopologyRepresentation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTopologyRepresentation : IIfcShapeModel
	{
	}
}

namespace Xbim.Ifc4.Interfaces.RepresentationResource
{
	[ExpressType("IFCTOPOLOGYREPRESENTATION", 1107)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTopologyRepresentation : IfcShapeModel, IInstantiableEntity, IIfcTopologyRepresentation, IEqualityComparer<@IfcTopologyRepresentation>, IEquatable<@IfcTopologyRepresentation>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTopologyRepresentation(IModel model) : base(model) 		{ 
			Model = model; 
		}




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:             )) = 0;*/
		/*WR22:	WR22 : EXISTS(SELF\IfcRepresentation.RepresentationType);*/
		/*WR23:	WR23 : IfcTopologyRepresentationTypes(SELF\IfcRepresentation.RepresentationType, SELF\IfcRepresentation.Items);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTopologyRepresentation other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTopologyRepresentation
            var root = (@IfcTopologyRepresentation)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTopologyRepresentation left, @IfcTopologyRepresentation right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTopologyRepresentation left, @IfcTopologyRepresentation right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTopologyRepresentation x, @IfcTopologyRepresentation y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTopologyRepresentation obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}