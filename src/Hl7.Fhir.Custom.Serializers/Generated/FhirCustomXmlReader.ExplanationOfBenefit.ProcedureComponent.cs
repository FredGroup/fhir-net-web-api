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
		public void Parse(Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							Parse(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_type, reader, outcome); // 50
							result.Type.Add(newItem_type);
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 60
							break;
						case "procedureCodeableConcept":
							result.Procedure = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Procedure as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "procedureReference":
							result.Procedure = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Procedure as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "udi":
							var newItem_udi = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_udi, reader, outcome); // 80
							result.Udi.Add(newItem_udi);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ExplanationOfBenefit.ProcedureComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "sequence":
							result.SequenceElement = new Hl7.Fhir.Model.PositiveInt();
							await ParseAsync(result.SequenceElement as Hl7.Fhir.Model.PositiveInt, reader, outcome); // 40
							break;
						case "type":
							var newItem_type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_type, reader, outcome); // 50
							result.Type.Add(newItem_type);
							break;
						case "date":
							result.DateElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.DateElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 60
							break;
						case "procedureCodeableConcept":
							result.Procedure = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Procedure as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 70
							break;
						case "procedureReference":
							result.Procedure = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Procedure as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "udi":
							var newItem_udi = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_udi, reader, outcome); // 80
							result.Udi.Add(newItem_udi);
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
