﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[Description("The root in which all other elements are embedded. Appears as a diagram.")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface IEndpointModel  
	{
		/// <summary>
		/// Gets the identifier for this element.
		/// </summary>
		[Description("Gets the identifier for this element.")]
		global::System.Guid Id { get; } 
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EndpointModel
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EndpointModel")]
		IEnumerable<IEvent> Events { get; }
		
		/// <summary>
		/// Creates an instance of a child <see cref="IEvent"/>, which is automatically added to the <c>Events</c> collection.
		/// </summary>
		IEvent CreateEvent(Action<IEvent> initializer = null);
		
		/// <summary>
		/// Deletes an instance of a child <see cref="IEvent"/>, which is removed from the <c>Events</c> collection.
		/// </summary>
		void DeleteEvent(IEvent instance);
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointModel
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointModel")]
		IEnumerable<IEndpoint> Endpoints { get; }
		
		/// <summary>
		/// Creates an instance of a child <see cref="ISendEndpoint"/>, which is automatically added to the <c>Endpoints</c> collection.
		/// </summary>
		ISendEndpoint CreateSendEndpoint(Action<ISendEndpoint> initializer = null);
		
		/// <summary>
		/// Creates an instance of a child <see cref="ISendReceiveEndpoint"/>, which is automatically added to the <c>Endpoints</c> collection.
		/// </summary>
		ISendReceiveEndpoint CreateSendReceiveEndpoint(Action<ISendReceiveEndpoint> initializer = null);
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.EndpointModel
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.EndpointModel")]
		IEnumerable<ICommand> Commands { get; }
		
		/// <summary>
		/// Creates an instance of a child <see cref="ICommand"/>, which is automatically added to the <c>Commands</c> collection.
		/// </summary>
		ICommand CreateCommand(Action<ICommand> initializer = null);
		
		/// <summary>
		/// Deletes an instance of a child <see cref="ICommand"/>, which is removed from the <c>Commands</c> collection.
		/// </summary>
		void DeleteCommand(ICommand instance);
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[Description("Elements embedded in the model. Appear as boxes on the diagram.")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface ISendEndpoint : IEndpoint 
	{
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.SendEndpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.SendEndpoint")]
		IEnumerable<ICommand> EmittedCommands { get; }
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Description for NServiceBus.Modeling.EndpointDesign.NamedElement
	/// </summary>
	[Description("Description for NServiceBus.Modeling.EndpointDesign.NamedElement")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface INamedElement  
	{
		/// <summary>
		/// Gets the identifier for this element.
		/// </summary>
		[Description("Gets the identifier for this element.")]
		global::System.Guid Id { get; } 
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.NamedElement.Name
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.NamedElement.Name")]
		global::System.String Name { get; set; }
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpoint
	/// </summary>
	[Description("Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpoint")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface ISendReceiveEndpoint : IEndpoint 
	{
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.SendReceiveEndpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.SendReceiveEndpoint")]
		IEnumerable<ICommand> ProcessCommands { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.SendReceiveEndpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.SendReceiveEndpoint")]
		IEnumerable<IEvent> ProcessEvents { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.SendReceiveEndpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.SendReceiveEndpoint")]
		IEnumerable<IEvent> EmittedEvents { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.SendReceiveEndpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.SendReceiveEndpoint")]
		IEnumerable<ICommand> EmittedCommands { get; }
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Description for NServiceBus.Modeling.EndpointDesign.Event
	/// </summary>
	[Description("Description for NServiceBus.Modeling.EndpointDesign.Event")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface IEvent : INamedElement 
	{
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.Event
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.Event")]
		IEndpointModel EndpointModel { get; set; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.Event
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.Event")]
		IEnumerable<ISendReceiveEndpoint> ProcessingEndpoints { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.Event
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.Event")]
		IEnumerable<ISendReceiveEndpoint> EmitterEndpoint { get; }
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Description for NServiceBus.Modeling.EndpointDesign.Command
	/// </summary>
	[Description("Description for NServiceBus.Modeling.EndpointDesign.Command")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface ICommand : INamedElement 
	{
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.Command
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.Command")]
		IEndpointModel EndpointModel { get; set; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.Command
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.Command")]
		IEnumerable<ISendReceiveEndpoint> ProcessingEndpoint { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.Command
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.Command")]
		IEnumerable<ISendEndpoint> SendEndpoints { get; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.Command
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.Command")]
		IEnumerable<ISendReceiveEndpoint> SendReceiveEndpoints { get; }
	}
}

namespace NServiceBus.Modeling.EndpointDesign.Interfaces
{ 
	/// <summary>
	/// Description for NServiceBus.Modeling.EndpointDesign.Endpoint
	/// </summary>
	[Description("Description for NServiceBus.Modeling.EndpointDesign.Endpoint")]
	[GeneratedCode("NServiceBus.Modeling", "1.0.0.0")]
	public partial interface IEndpoint : INamedElement 
	{
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.Endpoint.Type
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.Endpoint.Type")]
		global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType Type { get; set; }
		
		/// <summary>
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.Endpoint
		/// </summary>
		[Description("Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.Endpoint")]
		IEndpointModel EndpointModel { get; set; }
	}
}

