﻿namespace Ett.Common.Services.Models.Interfaces
{
    public interface IPagable
    {
        int? PageSize { get; }

        int? PageNumber { get; }
    }
}
