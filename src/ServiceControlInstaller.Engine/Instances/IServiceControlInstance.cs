﻿namespace ServiceControlInstaller.Engine.Instances
{
    using ServiceControlInstaller.Engine.Validation;

    public interface IServiceControlInstance : IContainPort, IContainInstancePaths, IContainTransportInfo, IServiceAccount
    {
        string Name { get; }
        string VirtualDirectory { get; }
        bool ForwardAuditMessages { get; }
        string HostName { get; }
    }
}