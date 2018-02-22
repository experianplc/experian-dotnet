namespace Experian.Api.Client.Bis
{
using System;
using System.Collections.Generic;

public sealed class BusinessFactsResult
{
    public int YearsOnFile { get; set; }

    public string StateOfIncorporation { get; set; }

    public string DateOfIncorporation { get; set; }

    public string BusinessType { get; set; }

    public int EmployeeSize { get; set; }

    public string EmployeeSizeCode { get; set; }

    public int? SalesRevenue { get; set; }

    public string SalesSizeCode { get; set; }

    public string StockExchange { get; set; }

    public string TickerSymbol { get; set; }

    public bool NonProfitIndicator { get; set; }

    public BusinessHeaderResult BusinessHeader { get; set; }

    public List<NaicsCodesResult> NaicsCodes { get; set; }

    public bool PublicIndicator { get; set; }

    public List<SicCodesResult> SicCodes { get; set; }

    public Fortune1000Result Fortune1000 { get; set; }

    public string CorporateLinkageType { get; set; }

    public List<ExecutiveInformationResult> ExecutiveInformation { get; set; }
}
}
