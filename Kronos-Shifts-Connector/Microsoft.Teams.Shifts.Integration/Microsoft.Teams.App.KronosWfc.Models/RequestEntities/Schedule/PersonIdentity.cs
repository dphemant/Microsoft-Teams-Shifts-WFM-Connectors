﻿// <copyright file="PersonIdentity.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.App.KronosWfc.Models.RequestEntities.Schedule
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// This class models the PersonIdentity.
    /// </summary>
    [Serializable]
    public class PersonIdentity
    {
        /// <summary>
        /// Gets or sets the PersonNumber.
        /// </summary>
        [XmlAttribute]
        public string PersonNumber { get; set; }
    }
}