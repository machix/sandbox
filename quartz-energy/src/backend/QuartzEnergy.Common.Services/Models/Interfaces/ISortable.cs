﻿namespace QuartzEnergy.Common.Services.Models.Interfaces
{
    public interface ISortable
    {
        string SortBy { get; }

        bool Desc { get; }
    }
}
