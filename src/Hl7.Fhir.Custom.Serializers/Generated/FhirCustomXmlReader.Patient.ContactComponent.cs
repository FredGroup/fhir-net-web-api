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
		public void Parse(Hl7.Fhir.Model.Patient.ContactComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_relationship, reader, outcome); // 40
							result.Relationship.Add(newItem_relationship);
							break;
						case "name":
							result.Name = new Hl7.Fhir.Model.HumanName();
							Parse(result.Name as Hl7.Fhir.Model.HumanName, reader, outcome); // 50
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							Parse(newItem_telecom, reader, outcome); // 60
							result.Telecom.Add(newItem_telecom);
							break;
						case "address":
							result.Address = new Hl7.Fhir.Model.Address();
							Parse(result.Address as Hl7.Fhir.Model.Address, reader, outcome); // 70
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							Parse(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 80
							break;
						case "organization":
							result.Organization = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.Organization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 90
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 100
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Patient.ContactComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "relationship":
							var newItem_relationship = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_relationship, reader, outcome); // 40
							result.Relationship.Add(newItem_relationship);
							break;
						case "name":
							result.Name = new Hl7.Fhir.Model.HumanName();
							await ParseAsync(result.Name as Hl7.Fhir.Model.HumanName, reader, outcome); // 50
							break;
						case "telecom":
							var newItem_telecom = new Hl7.Fhir.Model.ContactPoint();
							await ParseAsync(newItem_telecom, reader, outcome); // 60
							result.Telecom.Add(newItem_telecom);
							break;
						case "address":
							result.Address = new Hl7.Fhir.Model.Address();
							await ParseAsync(result.Address as Hl7.Fhir.Model.Address, reader, outcome); // 70
							break;
						case "gender":
							result.GenderElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>();
							await ParseAsync(result.GenderElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AdministrativeGender>, reader, outcome); // 80
							break;
						case "organization":
							result.Organization = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.Organization as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 90
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 100
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
