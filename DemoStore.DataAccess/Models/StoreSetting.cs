using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class StoreSetting
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Country { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Address { get; set; }

    public string? CustomerCareNumber { get; set; }

    public string? GstNumber { get; set; }

    public string? FacebookUrl { get; set; }

    public string? InstagramUrl { get; set; }

    public string? TwitterUrl { get; set; }

    public string? YoutubeUrl { get; set; }

    public string? FirebaseKey { get; set; }

    public string? MailFromAddress { get; set; }

    public string? CustomerSupportEmail { get; set; }

    public string? NewOrderNotificationsEmail { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? BackgroundColor { get; set; }

    public string? TextColor { get; set; }

    public string? BorderColor { get; set; }

    public string? HoverColor { get; set; }

    public string? BulkgateAppId { get; set; }

    public string? BulkgateAppToken { get; set; }

    public bool? AllowCashOnDelivery { get; set; }

    public string? CountryCode { get; set; }

    public int? StateId { get; set; }

    public bool? AllowDuePayments { get; set; }

    public bool? PrintA4Format { get; set; }
}
