﻿// <copyright file="SqlClientInstrumentationOptions.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
using System.Data;

namespace OpenTelemetry.Instrumentation.Dependencies
{
    /// <summary>
    /// Options for <see cref="SqlClientInstrumentation"/>.
    /// </summary>
    public class SqlClientInstrumentationOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlClientInstrumentationOptions"/> class.
        /// </summary>
        public SqlClientInstrumentationOptions()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not the <see cref="SqlClientInstrumentation"/> should capture the names of <see cref="CommandType.StoredProcedure"/> commands. Default value: True.
        /// </summary>
        public bool CaptureStoredProcedureCommandName { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether or not the <see cref="SqlClientInstrumentation"/> should capture the text of <see cref="CommandType.Text"/> commands. Default value: False.
        /// </summary>
        public bool CaptureTextCommandContent { get; set; }
    }
}
