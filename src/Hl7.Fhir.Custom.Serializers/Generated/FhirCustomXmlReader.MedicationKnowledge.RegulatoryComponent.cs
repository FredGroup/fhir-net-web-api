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
		public void Parse(Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "regulatoryAuthority":
							result.RegulatoryAuthority = new Hl7.Fhir.Model.ResourceReference();
							Parse(result.RegulatoryAuthority as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
							break;
						case "substitution":
							var newItem_substitution = new Hl7.Fhir.Model.MedicationKnowledge.SubstitutionComponent();
							Parse(newItem_substitution, reader, outcome); // 50
							result.Substitution.Add(newItem_substitution);
							break;
						case "schedule":
							var newItem_schedule = new Hl7.Fhir.Model.MedicationKnowledge.ScheduleComponent();
							Parse(newItem_schedule, reader, outcome); // 60
							result.Schedule.Add(newItem_schedule);
							break;
						case "maxDispense":
							result.MaxDispense = new Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent();
							Parse(result.MaxDispense as Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent, reader, outcome); // 70
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.MedicationKnowledge.RegulatoryComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "regulatoryAuthority":
							result.RegulatoryAuthority = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(result.RegulatoryAuthority as Hl7.Fhir.Model.ResourceReference, reader, outcome); // 40
							break;
						case "substitution":
							var newItem_substitution = new Hl7.Fhir.Model.MedicationKnowledge.SubstitutionComponent();
							await ParseAsync(newItem_substitution, reader, outcome); // 50
							result.Substitution.Add(newItem_substitution);
							break;
						case "schedule":
							var newItem_schedule = new Hl7.Fhir.Model.MedicationKnowledge.ScheduleComponent();
							await ParseAsync(newItem_schedule, reader, outcome); // 60
							result.Schedule.Add(newItem_schedule);
							break;
						case "maxDispense":
							result.MaxDispense = new Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent();
							await ParseAsync(result.MaxDispense as Hl7.Fhir.Model.MedicationKnowledge.MaxDispenseComponent, reader, outcome); // 70
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
