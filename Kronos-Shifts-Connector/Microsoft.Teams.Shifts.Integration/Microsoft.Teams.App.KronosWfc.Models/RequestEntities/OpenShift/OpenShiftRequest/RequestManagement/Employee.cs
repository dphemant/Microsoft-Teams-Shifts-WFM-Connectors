﻿// <copyright file="Employee.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.App.KronosWfc.Models.RequestEntities.OpenShift.OpenShiftRequest.RequestManagement
{
    using System.Xml.Serialization;

    /// <summary>
    /// This class models the Employee.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Gets or sets the PersonIdentity.
        /// </summary>
        [XmlElement("PersonIdentity")]
        public PersonIdentity PersonIdentity { get; set; }
    }
}