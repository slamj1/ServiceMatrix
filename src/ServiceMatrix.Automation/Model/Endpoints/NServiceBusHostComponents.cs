﻿namespace NServiceBusStudio
{
    using System;
    using System.Collections.Generic;
    using AbstractEndpoint;

    partial class NServiceBusHostComponents : IAbstractEndpointComponents
    {
        public IAbstractComponentLink CreateComponentLink(string name, Action<IAbstractComponentLink> initializer = null, bool raiseInstantiateEvents = true)
        {
            var result = CreateNServiceBusHostComponentLink(name, new Action<IAbstractComponentLink>(initializer), raiseInstantiateEvents);
            result.SetNextOrderNumber();
            return result;
        }

        public IEnumerable<IAbstractComponentLink> AbstractComponentLinks
        {
            get
            {
                return NServiceBusHostComponentLinks;
            }
        }

        public IAbstractEndpoint ParentEndpoint
        {
            get { return Parent; }
        }
    }
}
