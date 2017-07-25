using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class IfcRationalBezierCurve : IExpressValidatable
	{
		public enum IfcRationalBezierCurveClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRationalBezierCurveClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRationalBezierCurveClause.WR1:
						retVal = Functions.SIZEOF(WeightsData) == Functions.SIZEOF(this/* as IfcBSplineCurve*/.ControlPointsList);
						break;
					case IfcRationalBezierCurveClause.WR2:
						retVal = Functions.IfcCurveWeightsPositive(this);
						break;
				}
			} catch (Exception ex) {
				var log = ApplicationLogging.CreateLogger<Xbim.Ifc2x3.GeometryResource.IfcRationalBezierCurve>();
				log.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRationalBezierCurve.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRationalBezierCurveClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBezierCurve.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRationalBezierCurveClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBezierCurve.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
