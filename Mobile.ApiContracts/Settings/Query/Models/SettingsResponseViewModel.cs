namespace Mobile.ApiContracts.Settings.Query.Models
{
    public sealed record SettingsResponseViewModel
    {
        public bool IsRegistered { get; set; }

        public string Message { get; set; } = null!;

        public SettingViewModel? Settings { get; set; }
    }
}
