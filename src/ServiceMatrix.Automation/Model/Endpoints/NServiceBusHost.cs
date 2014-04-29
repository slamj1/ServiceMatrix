﻿namespace NServiceBusStudio
{
    using System.Collections.Generic;
    using NServiceBusStudio.Automation.Extensions;
    using AbstractEndpoint;
    using NuPattern.VisualStudio.Solution;

    partial interface INServiceBusHost : IAbstractEndpoint
    {

    }

    partial class NServiceBusHost
    {
        public IProject Project
        {
            get { return AsElement().GetProject(); }
        }

        public IAbstractEndpointComponents EndpointComponents
        {
            get { return (NServiceBusHostComponents)NServiceBusHostComponents; }
        }

        partial void Initialize()
        {
            AbstractEndpointExtensions.CheckNameUniqueness(this);

            AbstractEndpointExtensions.RaiseOnInitializing(this);

            ErrorQueueChanged += (s, e) =>
            {
                SetOverridenProperties("ErrorQueue", ErrorQueue != AsElement().Root.As<IApplication>().ErrorQueue);
            };
            ForwardReceivedMessagesToChanged += (s, e) =>
            {
                SetOverridenProperties("ForwardReceivedMessagesTo", ForwardReceivedMessagesTo != AsElement().Root.As<IApplication>().ForwardReceivedMessagesTo);
            };
        }

        private List<string> overridenProperties = new List<string>();

        public IEnumerable<string> OverridenProperties
        {
            get { return overridenProperties; }
        }

        private void SetOverridenProperties(string propertyName, bool doOverride)
        {
            if (!doOverride)
            {
                if (overridenProperties.Contains(propertyName))
                {
                    overridenProperties.Remove(propertyName);
                }
            }
            else
            {
                if (!overridenProperties.Contains(propertyName))
                {
                    overridenProperties.Add(propertyName);
                }
            }
        }

        public EndpointCustomizationFuncs Customization { get { return null; } }
    }
}
