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
		public void Parse(Hl7.Fhir.Model.ProdCharacteristic result, XmlReader reader, OperationOutcome outcome)
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
						case "height":
							result.Height = new Hl7.Fhir.Model.Quantity();
							Parse(result.Height as Hl7.Fhir.Model.Quantity, reader, outcome); // 90
							break;
						case "width":
							result.Width = new Hl7.Fhir.Model.Quantity();
							Parse(result.Width as Hl7.Fhir.Model.Quantity, reader, outcome); // 100
							break;
						case "depth":
							result.Depth = new Hl7.Fhir.Model.Quantity();
							Parse(result.Depth as Hl7.Fhir.Model.Quantity, reader, outcome); // 110
							break;
						case "weight":
							result.Weight = new Hl7.Fhir.Model.Quantity();
							Parse(result.Weight as Hl7.Fhir.Model.Quantity, reader, outcome); // 120
							break;
						case "nominalVolume":
							result.NominalVolume = new Hl7.Fhir.Model.Quantity();
							Parse(result.NominalVolume as Hl7.Fhir.Model.Quantity, reader, outcome); // 130
							break;
						case "externalDiameter":
							result.ExternalDiameter = new Hl7.Fhir.Model.Quantity();
							Parse(result.ExternalDiameter as Hl7.Fhir.Model.Quantity, reader, outcome); // 140
							break;
						case "shape":
							result.ShapeElement = new Hl7.Fhir.Model.FhirString();
							Parse(result.ShapeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "color":
							var newItem_color = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_color, reader, outcome); // 160
							result.ColorElement.Add(newItem_color);
							break;
						case "imprint":
							var newItem_imprint = new Hl7.Fhir.Model.FhirString();
							Parse(newItem_imprint, reader, outcome); // 170
							result.ImprintElement.Add(newItem_imprint);
							break;
						case "image":
							var newItem_image = new Hl7.Fhir.Model.Attachment();
							Parse(newItem_image, reader, outcome); // 180
							result.Image.Add(newItem_image);
							break;
						case "scoring":
							result.Scoring = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.Scoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
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

		public async System.Threading.Tasks.Task ParseAsync(Hl7.Fhir.Model.ProdCharacteristic result, XmlReader reader, OperationOutcome outcome)
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
						case "height":
							result.Height = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Height as Hl7.Fhir.Model.Quantity, reader, outcome); // 90
							break;
						case "width":
							result.Width = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Width as Hl7.Fhir.Model.Quantity, reader, outcome); // 100
							break;
						case "depth":
							result.Depth = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Depth as Hl7.Fhir.Model.Quantity, reader, outcome); // 110
							break;
						case "weight":
							result.Weight = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.Weight as Hl7.Fhir.Model.Quantity, reader, outcome); // 120
							break;
						case "nominalVolume":
							result.NominalVolume = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.NominalVolume as Hl7.Fhir.Model.Quantity, reader, outcome); // 130
							break;
						case "externalDiameter":
							result.ExternalDiameter = new Hl7.Fhir.Model.Quantity();
							await ParseAsync(result.ExternalDiameter as Hl7.Fhir.Model.Quantity, reader, outcome); // 140
							break;
						case "shape":
							result.ShapeElement = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(result.ShapeElement as Hl7.Fhir.Model.FhirString, reader, outcome); // 150
							break;
						case "color":
							var newItem_color = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_color, reader, outcome); // 160
							result.ColorElement.Add(newItem_color);
							break;
						case "imprint":
							var newItem_imprint = new Hl7.Fhir.Model.FhirString();
							await ParseAsync(newItem_imprint, reader, outcome); // 170
							result.ImprintElement.Add(newItem_imprint);
							break;
						case "image":
							var newItem_image = new Hl7.Fhir.Model.Attachment();
							await ParseAsync(newItem_image, reader, outcome); // 180
							result.Image.Add(newItem_image);
							break;
						case "scoring":
							result.Scoring = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.Scoring as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 190
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
