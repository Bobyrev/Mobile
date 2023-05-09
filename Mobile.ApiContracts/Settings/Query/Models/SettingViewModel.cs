namespace Mobile.ApiContracts.Settings.Query.Models
{
    public record SettingViewModel
    {
        public string? UseLocation { get; set; }

        public bool ShowAdv { get; set; }

        public bool EnableAutoPayment { get; set; }

        public string? BackgoundColor { get; set; }

        public string? ButtonsColor { get; set; }

        public string? TextColor { get; set; }
    }
}
