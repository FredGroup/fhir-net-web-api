﻿// -----------------------------------------------------------------------------
// GENERATED CODE - DO NOT EDIT
// -----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.Threading;

namespace Hl7.Fhir.CustomSerializer
{
    public partial class FhirCustomXmlReader
    {
		public void Parse(Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

			// otherwise proceed to read all the other nodes
			while (reader.Read())
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "orientationOfPolymerisation":
							result.OrientationOfPolymerisation = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.OrientationOfPolymerisation as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "repeatUnit":
							result.RepeatUnitElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.RepeatUnitElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SubstanceAmount();
							Parse(result.Amount as Hl7.Fhir.Model.SubstanceAmount, reader, outcome); // 60
							break;
						case "degreeOfPolymerisation":
							var newItem_degreeOfPolymerisation = new Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent();
							Parse(newItem_degreeOfPolymerisation, reader, outcome); // 70
							result.DegreeOfPolymerisation.Add(newItem_degreeOfPolymerisation);
							break;
						case "structuralRepresentation":
							var newItem_structuralRepresentation = new Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent();
							Parse(newItem_structuralRepresentation, reader, outcome); // 80
							result.StructuralRepresentation.Add(newItem_structuralRepresentation);
							break;
						default:
							// Property not found
							HandlePropertyNotFound(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstancePolymer.RepeatUnitComponent result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;
			
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					switch (reader.Name)
					{
						case "id":
							result.ElementId = reader.Value;
							break;
					}
				} while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}

			if (reader.IsEmptyElement)
			{
				// contextLocation.Pop();
				return;
			}

			// otherwise proceed to read all the other nodes
			while (await reader.ReadAsync().ConfigureAwait(false))
			{
				if (reader.IsStartElement())
				{
					switch (reader.Name)
					{
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 20
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 30
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "orientationOfPolymerisation":
							result.OrientationOfPolymerisation = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.OrientationOfPolymerisation as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 40
							break;
						case "repeatUnit":
							result.RepeatUnitElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.RepeatUnitElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 50
							break;
						case "amount":
							result.Amount = new Hl7.Fhir.Model.SubstanceAmount();
							await ParseAsync(result.Amount as Hl7.Fhir.Model.SubstanceAmount, reader, outcome); // 60
							break;
						case "degreeOfPolymerisation":
							var newItem_degreeOfPolymerisation = new Hl7.Fhir.Model.SubstancePolymer.DegreeOfPolymerisationComponent();
							await ParseAsync(newItem_degreeOfPolymerisation, reader, outcome); // 70
							result.DegreeOfPolymerisation.Add(newItem_degreeOfPolymerisation);
							break;
						case "structuralRepresentation":
							var newItem_structuralRepresentation = new Hl7.Fhir.Model.SubstancePolymer.StructuralRepresentationComponent();
							await ParseAsync(newItem_structuralRepresentation, reader, outcome); // 80
							result.StructuralRepresentation.Add(newItem_structuralRepresentation);
							break;
						default:
							// Property not found
							await HandlePropertyNotFoundAsync(reader, outcome, "unknown");
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}
	}
}
