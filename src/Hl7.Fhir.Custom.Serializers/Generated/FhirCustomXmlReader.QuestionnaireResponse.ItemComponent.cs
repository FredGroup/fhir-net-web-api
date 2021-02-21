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
		public void Parse(Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "linkId":
							result.LinkIdElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.LinkIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirUri();
							Parse(result.DefinitionElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 50
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.QuestionnaireResponse.AnswerComponent();
							Parse(newItem_answer, reader, outcome); // 70
							result.Answer.Add(newItem_answer);
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent();
							Parse(newItem_item, reader, outcome); // 80
							result.Item.Add(newItem_item);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "linkId":
							result.LinkIdElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.LinkIdElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "definition":
							result.DefinitionElement = new Hl7.Fhir.Model.FhirUri();
							await ParseAsync(result.DefinitionElement as Hl7.Fhir.Model.FhirUri, reader, outcome); // 50
							break;
						case "text":
							result.TextElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.TextElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 60
							break;
						case "answer":
							var newItem_answer = new Hl7.Fhir.Model.QuestionnaireResponse.AnswerComponent();
							await ParseAsync(newItem_answer, reader, outcome); // 70
							result.Answer.Add(newItem_answer);
							break;
						case "item":
							var newItem_item = new Hl7.Fhir.Model.QuestionnaireResponse.ItemComponent();
							await ParseAsync(newItem_item, reader, outcome); // 80
							result.Item.Add(newItem_item);
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
