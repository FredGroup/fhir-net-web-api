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
		public void Parse(Hl7.Fhir.Model.CarePlan.ActivityComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "outcomeCodeableConcept":
							var newItem_outcomeCodeableConcept = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_outcomeCodeableConcept, reader, outcome); // 40
							result.OutcomeCodeableConcept.Add(newItem_outcomeCodeableConcept);
							break;
						case "outcomeReference":
							var newItem_outcomeReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_outcomeReference, reader, outcome); // 50
							result.OutcomeReference.Add(newItem_outcomeReference);
							break;
						case "progress":
							var newItem_progress = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_progress, reader, outcome); // 60
							result.Progress.Add(newItem_progress);
							break;
						case "reference":
							result.Reference = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Reference as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "detail":
							result.Detail = new Hl7.Fhir.Model.CarePlan.DetailComponent();
							Parse(result.Detail as Hl7.Fhir.Model.CarePlan.DetailComponent, reader, outcome); // 80
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.CarePlan.ActivityComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "outcomeCodeableConcept":
							var newItem_outcomeCodeableConcept = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_outcomeCodeableConcept, reader, outcome); // 40
							result.OutcomeCodeableConcept.Add(newItem_outcomeCodeableConcept);
							break;
						case "outcomeReference":
							var newItem_outcomeReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_outcomeReference, reader, outcome); // 50
							result.OutcomeReference.Add(newItem_outcomeReference);
							break;
						case "progress":
							var newItem_progress = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_progress, reader, outcome); // 60
							result.Progress.Add(newItem_progress);
							break;
						case "reference":
							result.Reference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Reference as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 70
							break;
						case "detail":
							result.Detail = new Hl7.Fhir.Model.CarePlan.DetailComponent();
							await ParseAsync(result.Detail as Hl7.Fhir.Model.CarePlan.DetailComponent, reader, outcome); // 80
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
