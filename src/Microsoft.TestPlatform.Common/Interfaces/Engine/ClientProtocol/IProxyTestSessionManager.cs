﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine
{
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

    /// <summary>
    /// THIS API IS INTERNAL AND IT'S SUBJECT TO CHANGE.
    /// Orchestrates test session related functionality for the engine communicating with the
    /// client.
    /// </summary>
    public interface IProxyTestSessionManager
    {
        /// <summary>
        /// THIS API IS INTERNAL AND IT'S SUBJECT TO CHANGE.
        /// Initialize the proxy.
        /// </summary>
        /// 
        /// <param name="skipDefaultAdapters">Skip default adapters flag.</param>
        void Initialize(bool skipDefaultAdapters);

        /// <summary>
        /// THIS API IS INTERNAL AND IT'S SUBJECT TO CHANGE.
        /// Starts the test session based on the test session criteria.
        /// </summary>
        /// 
        /// <param name="criteria">The test session criteria.</param>
        /// <param name="eventsHandler">
        /// Event handler for handling events fired during test session management operations.
        /// </param>
        void StartSession(
            StartTestSessionCriteria criteria,
            ITestSessionEventsHandler eventsHandler);

        /// <summary>
        /// THIS API IS INTERNAL AND IT'S SUBJECT TO CHANGE.
        /// Stops the test session.
        /// </summary>
        void StopSession();
    }
}
