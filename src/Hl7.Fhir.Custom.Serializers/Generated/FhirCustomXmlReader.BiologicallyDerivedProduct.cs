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
		private void Parse(BiologicallyDerivedProduct result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							Parse(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "productCategory":
							result.ProductCategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>();
							Parse(result.ProductCategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>, reader, outcome); // 100
							break;
						case "productCode":
							result.ProductCode = new Hl7.Fhir.Model.CodeableConcept();
							Parse(result.ProductCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>();
							Parse(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>, reader, outcome); // 120
							break;
						case "request":
							var newItem_request = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_request, reader, outcome); // 130
							result.Request.Add(newItem_request);
							break;
						case "quantity":
							result.QuantityElement = new Hl7.Fhir.Model.Integer();
							Parse(result.QuantityElement as Hl7.Fhir.Model.Integer, reader, outcome); // 140
							break;
						case "parent":
							var newItem_parent = new Hl7.Fhir.Model.ResourceReference();
							Parse(newItem_parent, reader, outcome); // 150
							result.Parent.Add(newItem_parent);
							break;
						case "collection":
							result.Collection = new Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent();
							Parse(result.Collection as Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent, reader, outcome); // 160
							break;
						case "processing":
							var newItem_processing = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent();
							Parse(newItem_processing, reader, outcome); // 170
							result.Processing.Add(newItem_processing);
							break;
						case "manipulation":
							result.Manipulation = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent();
							Parse(result.Manipulation as Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent, reader, outcome); // 180
							break;
						case "storage":
							var newItem_storage = new Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent();
							Parse(newItem_storage, reader, outcome); // 190
							result.Storage.Add(newItem_storage);
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

		private async System.Threading.Tasks.Task ParseAsync(BiologicallyDerivedProduct result, XmlReader reader, OperationOutcome outcome)
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
						case "identifier":
							var newItem_identifier = new Hl7.Fhir.Model.Identifier();
							await ParseAsync(newItem_identifier, reader, outcome); // 90
							result.Identifier.Add(newItem_identifier);
							break;
						case "productCategory":
							result.ProductCategoryElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>();
							await ParseAsync(result.ProductCategoryElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductCategory>, reader, outcome); // 100
							break;
						case "productCode":
							result.ProductCode = new Hl7.Fhir.Model.CodeableConcept();
							await ParseAsync(result.ProductCode as Hl7.Fhir.Model.CodeableConcept, reader, outcome); // 110
							break;
						case "status":
							result.StatusElement = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>();
							await ParseAsync(result.StatusElement as Hl7.Fhir.Model.Code<Hl7.Fhir.Model.BiologicallyDerivedProduct.BiologicallyDerivedProductStatus>, reader, outcome); // 120
							break;
						case "request":
							var newItem_request = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_request, reader, outcome); // 130
							result.Request.Add(newItem_request);
							break;
						case "quantity":
							result.QuantityElement = new Hl7.Fhir.Model.Integer();
							await ParseAsync(result.QuantityElement as Hl7.Fhir.Model.Integer, reader, outcome); // 140
							break;
						case "parent":
							var newItem_parent = new Hl7.Fhir.Model.ResourceReference();
							await ParseAsync(newItem_parent, reader, outcome); // 150
							result.Parent.Add(newItem_parent);
							break;
						case "collection":
							result.Collection = new Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent();
							await ParseAsync(result.Collection as Hl7.Fhir.Model.BiologicallyDerivedProduct.CollectionComponent, reader, outcome); // 160
							break;
						case "processing":
							var newItem_processing = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ProcessingComponent();
							await ParseAsync(newItem_processing, reader, outcome); // 170
							result.Processing.Add(newItem_processing);
							break;
						case "manipulation":
							result.Manipulation = new Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent();
							await ParseAsync(result.Manipulation as Hl7.Fhir.Model.BiologicallyDerivedProduct.ManipulationComponent, reader, outcome); // 180
							break;
						case "storage":
							var newItem_storage = new Hl7.Fhir.Model.BiologicallyDerivedProduct.StorageComponent();
							await ParseAsync(newItem_storage, reader, outcome); // 190
							result.Storage.Add(newItem_storage);
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
