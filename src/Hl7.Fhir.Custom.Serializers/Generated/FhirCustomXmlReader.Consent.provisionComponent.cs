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
		public void Parse(Hl7.Fhir.Model.Consent.provisionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentProvisionType>();
							Parse(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentProvisionType>, reader, outcome); // 40
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							Parse(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 50
							break;
						case "actor":
							var newItem_actor = new Hl7.Fhir.Model.Consent.provisionActorComponent();
							Parse(newItem_actor, reader, outcome); // 60
							result.Actor.Add(newItem_actor);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_action, reader, outcome); // 70
							result.Action.Add(newItem_action);
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Coding();
							Parse(newItem_securityLabel, reader, outcome); // 80
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "purpose":
							var newItem_purpose = new Hl7.Fhir.Model.Coding();
							Parse(newItem_purpose, reader, outcome); // 90
							result.Purpose.Add(newItem_purpose);
							break;
						case "class":
							var newItem_class = new Hl7.Fhir.Model.Coding();
							Parse(newItem_class, reader, outcome); // 100
							result.Class.Add(newItem_class);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							Parse(newItem_code, reader, outcome); // 110
							result.Code.Add(newItem_code);
							break;
						case "dataPeriod":
							result.DataPeriod = new Hl7.Fhir.Model.Period();
							Parse(result.DataPeriod as Hl7.Fhir.Model.Period, reader, outcome); // 120
							break;
						case "data":
							var newItem_data = new Hl7.Fhir.Model.Consent.provisionDataComponent();
							Parse(newItem_data, reader, outcome); // 130
							result.Data.Add(newItem_data);
							break;
						case "provision":
							var newItem_provision = new Hl7.Fhir.Model.Consent.provisionComponent();
							Parse(newItem_provision, reader, outcome); // 140
							result.Provision.Add(newItem_provision);
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.Consent.provisionComponent result, XmlReader reader, OperationOutcome outcome)
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
						case "type":
							result.TypeElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentProvisionType>();
							await ParseAsync(result.TypeElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Consent.ConsentProvisionType>, reader, outcome); // 40
							break;
						case "period":
							result.Period = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.Period as Hl7.Fhir.Model.Period, reader, outcome); // 50
							break;
						case "actor":
							var newItem_actor = new Hl7.Fhir.Model.Consent.provisionActorComponent();
							await ParseAsync(newItem_actor, reader, outcome); // 60
							result.Actor.Add(newItem_actor);
							break;
						case "action":
							var newItem_action = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_action, reader, outcome); // 70
							result.Action.Add(newItem_action);
							break;
						case "securityLabel":
							var newItem_securityLabel = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_securityLabel, reader, outcome); // 80
							result.SecurityLabel.Add(newItem_securityLabel);
							break;
						case "purpose":
							var newItem_purpose = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_purpose, reader, outcome); // 90
							result.Purpose.Add(newItem_purpose);
							break;
						case "class":
							var newItem_class = new Hl7.Fhir.Model.Coding();
							await ParseAsync(newItem_class, reader, outcome); // 100
							result.Class.Add(newItem_class);
							break;
						case "code":
							var newItem_code = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(newItem_code, reader, outcome); // 110
							result.Code.Add(newItem_code);
							break;
						case "dataPeriod":
							result.DataPeriod = new Hl7.Fhir.Model.Period();
							await ParseAsync(result.DataPeriod as Hl7.Fhir.Model.Period, reader, outcome); // 120
							break;
						case "data":
							var newItem_data = new Hl7.Fhir.Model.Consent.provisionDataComponent();
							await ParseAsync(newItem_data, reader, outcome); // 130
							result.Data.Add(newItem_data);
							break;
						case "provision":
							var newItem_provision = new Hl7.Fhir.Model.Consent.provisionComponent();
							await ParseAsync(newItem_provision, reader, outcome); // 140
							result.Provision.Add(newItem_provision);
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
