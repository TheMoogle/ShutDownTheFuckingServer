﻿using Exiled.API.Interfaces;

namespace ShutDownTheFuckingServer
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
