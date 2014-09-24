﻿using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Hl7.Fhir.Api.Introspection.Source
{
    public class ResourceCollection
    {
        List<string> texts;

        public ResourceCollection(IEnumerable<string> texts)
        {
            this.texts = texts.ToList();
        }

        public IEnumerable<ResourceEntry> ResourceEntries()
        {
            foreach (string text in texts)
            {
                Bundle bundle = FhirParser.ParseBundleFromXml(text);
                foreach (ResourceEntry entry in bundle.Entries.OfType<ResourceEntry>())
                {
                    yield return entry;
                }
            }
        }

        public static IEnumerable<XElement> FeedEntries(XmlReader reader)
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                       && reader.LocalName == "entry"
                       && reader.NamespaceURI == BundleXmlParser.ATOMPUB_NS)
                {
                    XElement element = (XElement)XElement.ReadFrom(reader);
                    yield return element;
                }
            }
        }

        public static readonly XName ENTRY_CONTENT = XmlNs.XATOMNS + BundleXmlParser.XATOM_CONTENT;

        public static string Content(XElement element)
        {
            var contentElement = element.Element(ENTRY_CONTENT);
            var entryContentXml = contentElement.Elements().FirstOrDefault();
            return entryContentXml == null ? null : entryContentXml.ToString();
        }
    }
}
