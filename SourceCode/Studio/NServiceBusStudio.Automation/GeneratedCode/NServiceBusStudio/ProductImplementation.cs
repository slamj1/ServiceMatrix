﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NServiceBusStudio
{
	using global::NServiceBusStudio.Automation.TypeConverters;
	using global::NuPattern.Runtime;
	using global::NuPattern.Runtime.Bindings;
	using global::NuPattern.Runtime.ToolkitInterface;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using global::System.Windows.Forms.Design;
	using Runtime = global::NuPattern.Runtime;

	/// <summary>
	/// The root of your design.
	/// </summary>
	[Description("The root of your design.")]
	[ToolkitInterfaceProxy(ExtensionId = "a5e9f15b-ad7f-4201-851e-186dd8db3bc9", DefinitionId = "2c52bbfe-442d-4f40-8f6f-7df75dd99cac", ProxyType = typeof(Application))]
	[System.CodeDom.Compiler.GeneratedCode("NuPattern Toolkit Library", "1.3.23.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class Application : IApplication
	{

		private Runtime.IProduct target;
		private IProductProxy<IApplication> proxy;

		/// <summary>
		/// Creates a new instance of the <see cref="Application"/> class.
		/// </summary>
		[ImportingConstructor]
		private Application() { }

		/// <summary>
		/// Creates a new instance of the <see cref="Application"/> class.
		/// </summary>
		public Application(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IApplication>();
			OnCreated();
		}

		/// <summary>
		/// When overridden, initializes the class.
		/// </summary>
		partial void OnCreated();

		/// <summary>
		/// Description for Application.ForwardReceivedMessagesTo
		/// </summary>
		[Description("Description for Application.ForwardReceivedMessagesTo")]
		[DisplayName("Forward Received Messages To")]
		[Category("General")]
		public virtual String ForwardReceivedMessagesTo
		{
			get { return this.proxy.GetValue(() => this.ForwardReceivedMessagesTo); }
			set { this.proxy.SetValue(() => this.ForwardReceivedMessagesTo, value); }
		}

		/// <summary>
		/// Description for Application.ErrorQueue
		/// </summary>
		[Description("Description for Application.ErrorQueue")]
		[DisplayName("Error Queue")]
		[Category("General")]
		public virtual String ErrorQueue
		{
			get { return this.proxy.GetValue(() => this.ErrorQueue); }
			set { this.proxy.SetValue(() => this.ErrorQueue, value); }
		}

		/// <summary>
		/// Description for Application.NServiceBusVersion
		/// </summary>
		[Description("Description for Application.NServiceBusVersion")]
		[DisplayName("NService Bus Version")]
		[Category("General")]
		public virtual String NServiceBusVersion
		{
			get { return this.proxy.GetValue(() => this.NServiceBusVersion); }
			set { this.proxy.SetValue(() => this.NServiceBusVersion, value); }
		}

		/// <summary>
		/// Description for Application.ExtensionPath
		/// </summary>
		[Description("Description for Application.ExtensionPath")]
		[DisplayName("Extension Path")]
		[Category("General")]
		public virtual String ExtensionPath
		{
			get { return this.proxy.GetValue(() => this.ExtensionPath); }
			set { this.proxy.SetValue(() => this.ExtensionPath, value); }
		}

		/// <summary>
		/// Description for Application.Transport
		/// </summary>
		[Description("Description for Application.Transport")]
		[DisplayName("Transport")]
		[Category("General")]
		[TypeConverter(typeof(TransportTypeConverter))]
		public virtual String Transport
		{
			get { return this.proxy.GetValue(() => this.Transport); }
			set { this.proxy.SetValue(() => this.Transport, value); }
		}

		/// <summary>
		/// Description for Application.TransportConnectionString
		/// </summary>
		[Description("Description for Application.TransportConnectionString")]
		[DisplayName("Transport Connection String")]
		[Category("General")]
		public virtual String TransportConnectionString
		{
			get { return this.proxy.GetValue(() => this.TransportConnectionString); }
			set { this.proxy.SetValue(() => this.TransportConnectionString, value); }
		}

		/// <summary>
		/// Description for Application.CompanyLogo
		/// </summary>
		[Description("Description for Application.CompanyLogo")]
		[DisplayName("Company Logo")]
		[Category("General")]
		[Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
		public virtual String CompanyLogo
		{
			get { return this.proxy.GetValue(() => this.CompanyLogo); }
			set { this.proxy.SetValue(() => this.CompanyLogo, value); }
		}

		/// <summary>
		/// Description for Application.Title
		/// </summary>
		[Description("Description for Application.Title")]
		[DisplayName("Title")]
		[Category("General")]
		public virtual String Title
		{
			get { return this.proxy.GetValue(() => this.Title); }
			set { this.proxy.SetValue(() => this.Title, value); }
		}

		/// <summary>
		/// Description for Application.ToolkitVersion
		/// </summary>
		[Description("Description for Application.ToolkitVersion")]
		[DisplayName("Toolkit Version")]
		[Category("General")]
		public virtual String ToolkitVersion
		{
			get { return this.proxy.GetValue(() => this.ToolkitVersion); }
			set { this.proxy.SetValue(() => this.ToolkitVersion, value); }
		}

		/// <summary>
		/// Description for Application.ProjectNameInternalMessages
		/// </summary>
		[Description("Description for Application.ProjectNameInternalMessages")]
		[DisplayName("Project Name Internal Messages")]
		[Category("General")]
		public virtual String ProjectNameInternalMessages
		{
			get { return this.proxy.GetValue(() => this.ProjectNameInternalMessages); }
			set { this.proxy.SetValue(() => this.ProjectNameInternalMessages, value); }
		}

		/// <summary>
		/// Description for Application.ProjectNameContracts
		/// </summary>
		[Description("Description for Application.ProjectNameContracts")]
		[DisplayName("Project Name Contracts")]
		[Category("General")]
		public virtual String ProjectNameContracts
		{
			get { return this.proxy.GetValue(() => this.ProjectNameContracts); }
			set { this.proxy.SetValue(() => this.ProjectNameContracts, value); }
		}

		/// <summary>
		/// Description for Application.ProjectNameCode
		/// </summary>
		[Description("Description for Application.ProjectNameCode")]
		[DisplayName("Project Name Code")]
		[Category("General")]
		public virtual String ProjectNameCode
		{
			get { return this.proxy.GetValue(() => this.ProjectNameCode); }
			set { this.proxy.SetValue(() => this.ProjectNameCode, value); }
		}

		/// <summary>
		/// Description for Application.LicensedVersion
		/// </summary>
		[Description("Description for Application.LicensedVersion")]
		[DisplayName("Licensed Version")]
		[Category("General")]
		public virtual Boolean LicensedVersion
		{
			get { return this.proxy.GetValue(() => this.LicensedVersion); }
			set { this.proxy.SetValue(() => this.LicensedVersion, value); }
		}

		/// <summary>
		/// Description for Application.ServiceControlEndpointPluginVersion
		/// </summary>
		[Description("Description for Application.ServiceControlEndpointPluginVersion")]
		[DisplayName("Service Control Endpoint Plugin Version")]
		[Category("General")]
		public virtual String ServiceControlEndpointPluginVersion
		{
			get { return this.proxy.GetValue(() => this.ServiceControlEndpointPluginVersion); }
			set { this.proxy.SetValue(() => this.ServiceControlEndpointPluginVersion, value); }
		}

		/// <summary>
		/// The URI for an instance of the ServiceControl instance process. This will be used by ServiceMatrix for providing more information on solution's runtime behavior.
		/// </summary>
		[Description("The URI for an instance of the ServiceControl instance process. This will be used by ServiceMatrix for providing more information on solution's runtime behavior.")]
		[DisplayName("ServiceControl Instance URI")]
		[Category("Debugging")]
		public virtual String ServiceControlInstanceURI
		{
			get { return this.proxy.GetValue(() => this.ServiceControlInstanceURI); }
			set { this.proxy.SetValue(() => this.ServiceControlInstanceURI, value); }
		}

		/// <summary>
		/// When debugging the application, ServiceInsight will be launched, filtered (by default) to show messages created by the current Visual Studio debug activity.
		/// </summary>
		[Description("When debugging the application, ServiceInsight will be launched, filtered (by default) to show messages created by the current Visual Studio debug activity.")]
		[DisplayName("Launch ServiceInsight on Debug")]
		[Category("Debugging")]
		public virtual Boolean LaunchServiceInsightOnDebug
		{
			get { return this.proxy.GetValue(() => this.LaunchServiceInsightOnDebug); }
			set { this.proxy.SetValue(() => this.LaunchServiceInsightOnDebug, value); }
		}

		/// <summary>
		/// NServiceBus Nuget package version number
		/// </summary>
		[Description("NServiceBus Nuget package version number")]
		[DisplayName("NServiceBus version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBus
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBus); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBus, value); }
		}

		/// <summary>
		/// ServiceControl Plugins  Nuget package version number
		/// </summary>
		[Description("ServiceControl Plugins  Nuget package version number")]
		[DisplayName("ServiceControl Plugins version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionServiceControlPlugins
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionServiceControlPlugins); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionServiceControlPlugins, value); }
		}

		/// <summary>
		/// NServiceBus ActiveMQ  Nuget package version number
		/// </summary>
		[Description("NServiceBus ActiveMQ  Nuget package version number")]
		[DisplayName("NServiceBus ActiveMQ version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBusActiveMQ
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBusActiveMQ); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBusActiveMQ, value); }
		}

		/// <summary>
		/// NServiceBus RabbitMQ  Nuget package version number
		/// </summary>
		[Description("NServiceBus RabbitMQ  Nuget package version number")]
		[DisplayName("NServiceBus RabbitMQ version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBusRabbitMQ
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBusRabbitMQ); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBusRabbitMQ, value); }
		}

		/// <summary>
		/// NServiceBus Sql Server  Nuget package version number
		/// </summary>
		[Description("NServiceBus Sql Server  Nuget package version number")]
		[DisplayName("NServiceBus Sql Server version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBusSqlServer
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBusSqlServer); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBusSqlServer, value); }
		}

		/// <summary>
		/// NServiceBus AzureQueues  Nuget package version number
		/// </summary>
		[Description("NServiceBus AzureQueues  Nuget package version number")]
		[DisplayName("NServiceBus AzureQueues version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBusAzureQueues
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBusAzureQueues); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBusAzureQueues, value); }
		}

		/// <summary>
		/// NServiceBus AzureServiceBus  Nuget package version number
		/// </summary>
		[Description("NServiceBus AzureServiceBus  Nuget package version number")]
		[DisplayName("NServiceBus AzureServiceBus version")]
		[Category("Nuget Packages")]
		public virtual String NuGetPackageVersionNServiceBusAzureServiceBus
		{
			get { return this.proxy.GetValue(() => this.NuGetPackageVersionNServiceBusAzureServiceBus); }
			set { this.proxy.SetValue(() => this.NuGetPackageVersionNServiceBusAzureServiceBus, value); }
		}

		/// <summary>
		/// Gets or sets the ToolkitInfo property.
		/// </summary>
		public virtual IProductToolkitInfo ToolkitInfo
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}

		/// <summary>
		/// Gets or sets the CurrentView property.
		/// </summary>
		public virtual IView CurrentView
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}

		/// <summary>
		/// The name of this element instance.
		/// </summary>
		[Description("The name of this element instance.")]
		[ParenthesizePropertyName(true)]
		public virtual String InstanceName
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}

		/// <summary>
		/// The order of this element relative to its siblings.
		/// </summary>
		[Description("The order of this element relative to its siblings.")]
		[ReadOnly(true)]
		public virtual Double InstanceOrder
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}

		/// <summary>
		/// The references of this element.
		/// </summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}

		/// <summary>
		/// Notes for this element.
		/// </summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}

		/// <summary>
		/// Gets or sets the InTransaction property.
		/// </summary>
		public virtual Boolean InTransaction
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}

		/// <summary>
		/// Gets or sets the IsSerializing property.
		/// </summary>
		public virtual Boolean IsSerializing
		{ 
			get { return this.proxy.GetValue(() => this.IsSerializing); }
		}

		/// <summary>
		/// Design view of your application, where you create your services and messages.
		/// </summary>
		[Description("Design view of your application, where you create your services and messages.")]
		public virtual IDesign Design
		{
			get { return this.proxy.GetView(() => this.Design, view => new Design(view)); }
		}

		/// <summary>
		/// Deletes this element.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}

		/// <summary>
		/// Gets the generalized interface (<see cref="Runtime.IProduct"/>) of this element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the specified generalized interface of this element, if possible.
		/// </summary>
		public virtual TGeneralizedInterface As<TGeneralizedInterface>() where TGeneralizedInterface : class
		{
			return this.target as TGeneralizedInterface;
		}
	}
}
