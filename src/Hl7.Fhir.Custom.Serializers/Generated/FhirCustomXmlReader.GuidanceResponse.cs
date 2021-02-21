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
		private void Parse(GuidanceResponse result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!reader.Read())
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							Parse(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							Parse(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							Parse(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							Parse(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = Parse(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							Parse(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "requestIdentifier":
							result.RequestIdentifier = new Hl7.Fhir.Model.Identifier();
							Parse(result.RequestIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "moduleUri":
							result.Module = new Hl7.Fhir.Model.FhirUri();
							Parse(result.Module as Hl7.Fhir.Model.FhirUri, reader, outcome); // 110
							break;
						case "moduleCanonical":
							result.Module = new Hl7.Fhir.Model.Canonical();
							Parse(result.Module as Hl7.Fhir.Model.Canonical, reader, outcome); // 110
							break;
						case "moduleCodeableConcept":
							result.Module = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Module as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>, reader, outcome); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "occurrenceDateTime":
							result.OccurrenceDateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							Parse(result.OccurrenceDateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_reasonCode, reader, outcome); // 170
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_reasonReference, reader, outcome); // 180
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							Parse(newItem_note, reader, outcome); // 190
							result.Note.Add(newItem_note);
							break;
						case "evaluationMessage":
							var newItem_evaluationMessage = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_evaluationMessage, reader, outcome); // 200
							result.EvaluationMessage.Add(newItem_evaluationMessage);
							break;
						case "outputParameters":
							result.OutputParameters = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.OutputParameters as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "result":
							result.Result = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Result as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 220
							break;
						case "dataRequirement":
							var newItem_dataRequirement = new Hl7.Fhir.Model.DataRequirement();
							Parse(newItem_dataRequirement, reader, outcome); // 230
							result.DataRequirement.Add(newItem_dataRequirement);
							break;
						default:
							// Property not found
							// System.Diagnostics.Trace.WriteLine($\"Unexpected token found {reader.Name}\");
							HandlePropertyNotFound(reader, outcome, "unknown");
							// reader.ReadInnerXml();
							break;
					}
				}
				else if (reader.NodeType == XmlNodeType.EndElement || reader.IsStartElement() && reader.IsEmptyElement)
				{
					break;
				}
			}
		}

		private async System.Threading.Tasks.Task ParseAsync(GuidanceResponse result, XmlReader reader, OperationOutcome outcome)
		{
			// skip ignored elements
			while (ShouldSkipNodeType(reader.NodeType))
				if (!await reader.ReadAsync().ConfigureAwait(false))
					return;

			// if (reader.IsStartElement())
			// {
			//     if (contextLocation.Count > 0)
			//         contextLocation.Push(contextLocation.Peek() + "." + reader.Name);
			//     else
			//         contextLocation.Push(reader.Name);
			// }
			// System.Diagnostics.Trace.WriteLine(contextLocation.Peek());

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
						case "id":
							result.IdElement = new Hl7.Fhir.Model.Id();
							await ParseAsync(result.IdElement as Hl7.Fhir.Model.Id, reader, outcome); // 10
							break;
						case "meta":
							result.Meta = new Hl7.Fhir.Model.Meta();
							await ParseAsync(result.Meta as Hl7.Fhir.Model.Meta, reader, outcome); // 20
							break;
						case "implicitRules":
							result.ImplicitRulesElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.ImplicitRulesElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 30
							break;
						case "language":
							result.LanguageElement = new Hl7.Fhir.Model.Code();
							await ParseAsync(result.LanguageElement as Hl7.Fhir.Model.Code, reader, outcome); // 40
							break;
						case "text":
							result.Text = new Hl7.Fhir.Model.Narrative();
							await ParseAsync(result.Text as Hl7.Fhir.Model.Narrative, reader, outcome); // 50
							break;
						case "contained":
							// FirstChildOf(reader); // 60
							var ContainedResource = await ParseAsync(reader, outcome);
							if (ContainedResource != null)
								result.Contained.Add(ContainedResource);
							if (!reader.Read()) return;
							break;
						case "extension":
							var newItem_extension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_extension, reader, outcome); // 70
							result.Extension.Add(newItem_extension);
							break;
						case "modifierExtension":
							var newItem_modifierExtension = new Hl7.Fhir.Model.Extension();
							await ParseAsync(newItem_modifierExtension, reader, outcome); // 80
							result.ModifierExtension.Add(newItem_modifierExtension);
							break;
						case "requestIdentifier":
							result.RequestIdentifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(result.RequestIdentifier as Hl7.Fhir.Model.Identifier, reader, outcome); // 90
							break;
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 100
							result.Identifier.Add(newItem_identifier);
							break;
						case "moduleUri":
							result.Module = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.Module as Hl7.Fhir.Model.FhirUri, reader, outcome); // 110
							break;
						case "moduleCanonical":
							result.Module = new Hl7.Fhir.Model.Canonical();
							await ParseAsync(result.Module as Hl7.Fhir.Model.Canonical, reader, outcome); // 110
							break;
						case "moduleCodeableConcept":
							result.Module = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Module as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.GuidanceResponse.GuidanceResponseStatus>, reader, outcome); // 120
							break;
						case "subject":
							result.Subject = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Subject as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 130
							break;
						case "encounter":
							result.Encounter = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Encounter as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 140
							break;
						case "occurrenceDateTime":
							result.OccurrenceDateTimeElement = new Hl7.Fhir.Model.FhirDateTime();
							await ParseAsync(result.OccurrenceDateTimeElement as Hl7.Fhir.Model.FhirDateTime, reader, outcome); // 150
							break;
						case "performer":
							result.Performer = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Performer as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 160
							break;
						case "reasonCode":
							var newItem_reasonCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_reasonCode, reader, outcome); // 170
							result.ReasonCode.Add(newItem_reasonCode);
							break;
						case "reasonReference":
							var newItem_reasonReference = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_reasonReference, reader, outcome); // 180
							result.ReasonReference.Add(newItem_reasonReference);
							break;
						case "note":
							var newItem_note = new Hl7.Fhir.Model.Annotation();
							await ParseAsync(newItem_note, reader, outcome); // 190
							result.Note.Add(newItem_note);
							break;
						case "evaluationMessage":
							var newItem_evaluationMessage = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_evaluationMessage, reader, outcome); // 200
							result.EvaluationMessage.Add(newItem_evaluationMessage);
							break;
						case "outputParameters":
							result.OutputParameters = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.OutputParameters as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 210
							break;
						case "result":
							result.Result = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Result as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 220
							break;
						case "dataRequirement":
							var newItem_dataRequirement = new Hl7.Fhir.Model.DataRequirement();
							await ParseAsync(newItem_dataRequirement, reader, outcome); // 230
							result.DataRequirement.Add(newItem_dataRequirement);
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
