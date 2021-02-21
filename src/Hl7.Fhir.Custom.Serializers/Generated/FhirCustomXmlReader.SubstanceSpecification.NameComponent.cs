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
		public void Parse(Hl7.Fhir.Model.SubstanceSpecification.NameComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "preferred":
							result.PreferredElement = new Hl7.Fhir.Model.FhirBoolean();
							Parse(result.PreferredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 70
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_language, reader, outcome); // 80
							result.Language.Add(newItem_language);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_domain, reader, outcome); // 90
							result.Domain.Add(newItem_domain);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_jurisdiction, reader, outcome); // 100
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							Parse(newItem_synonym, reader, outcome); // 110
							result.Synonym.Add(newItem_synonym);
							break;
						case "translation":
							var newItem_translation = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							Parse(newItem_translation, reader, outcome); // 120
							result.Translation.Add(newItem_translation);
							break;
						case "official":
							var newItem_official = new Hl7.Fhir.Model.SubstanceSpecification.OfficialComponent();
							Parse(newItem_official, reader, outcome); // 130
							result.Official.Add(newItem_official);
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_source, reader, outcome); // 140
							result.Source.Add(newItem_source);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.SubstanceSpecification.NameComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "name":
							result.NameElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.NameElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 40
							break;
						case "type":
							result.Type = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Type as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 50
							break;
						case "status":
							result.Status = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Status as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 60
							break;
						case "preferred":
							result.PreferredElement = new Hl7.Fhir.Model.FhirBoolean();
							await ParseAsync(result.PreferredElement as Hl7.Fhir.Model.FhirBoolean, reader, outcome); // 70
							break;
						case "language":
							var newItem_language = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_language, reader, outcome); // 80
							result.Language.Add(newItem_language);
							break;
						case "domain":
							var newItem_domain = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_domain, reader, outcome); // 90
							result.Domain.Add(newItem_domain);
							break;
						case "jurisdiction":
							var newItem_jurisdiction = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_jurisdiction, reader, outcome); // 100
							result.Jurisdiction.Add(newItem_jurisdiction);
							break;
						case "synonym":
							var newItem_synonym = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							await ParseAsync(newItem_synonym, reader, outcome); // 110
							result.Synonym.Add(newItem_synonym);
							break;
						case "translation":
							var newItem_translation = new Hl7.Fhir.Model.SubstanceSpecification.NameComponent();
							await ParseAsync(newItem_translation, reader, outcome); // 120
							result.Translation.Add(newItem_translation);
							break;
						case "official":
							var newItem_official = new Hl7.Fhir.Model.SubstanceSpecification.OfficialComponent();
							await ParseAsync(newItem_official, reader, outcome); // 130
							result.Official.Add(newItem_official);
							break;
						case "source":
							var newItem_source = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_source, reader, outcome); // 140
							result.Source.Add(newItem_source);
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
