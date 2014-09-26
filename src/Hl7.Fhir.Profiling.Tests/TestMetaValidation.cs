﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Hl7.Fhir.Profiling;

namespace Fhir.Profiling.Tests
{
    [TestClass]
    public class TestCustomProfiles
    {
        static Specification spec;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            spec = Factory.GetProfileSpec(expand: true, online: false);
        }
       
        [TestMethod,Ignore]
        public void LipidProfile()
        {
            var resource = FhirFile.LoadResource("TestData\\lipid.profile.xml");
            Report report = Validation.Validate(resource);

            var errors = report.Errors.ToList();
            Assert.IsTrue(report.IsValid);
        }
    }
}
