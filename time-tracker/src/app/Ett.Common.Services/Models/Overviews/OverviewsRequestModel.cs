﻿namespace Ett.Common.Services.Models.Overviews
{
    using Ett.Common.DataAnnotations.Attributes.Numbers;
    using Ett.Common.Services.Models.Interfaces;

    public abstract class OverviewsRequestModel : ISortable, IPagable
    {
        protected OverviewsRequestModel(
            string sortBy,
            bool desc,
            int? pageSize,
            int? pageNumber)
        {
            this.SortBy = sortBy;
            this.Desc = desc;
            this.PageSize = pageSize;
            this.PageNumber = pageNumber;
        }

        public string SortBy { get; }

        public bool Desc { get; }

        [MinIntValue(1)]
        public int? PageSize { get; }

        [MinIntValue(1)]
        public int? PageNumber { get; }
    }
}
