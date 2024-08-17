using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoApi.Repository.ExternalServices.DTOs
{
public class PlatformDetail
    {
        [JsonProperty("decimal_place")]
        public int? DecimalPlace { get; set; }

        [JsonProperty("contract_address")]
        public string ContractAddress { get; set; }
    }

    public class Description
    {
        [JsonProperty("en")]
        public string English { get; set; }
    }

    public class Links
    {
        [JsonProperty("homepage")]
        public List<string> Homepage { get; set; }

        [JsonProperty("whitepaper")]
        public string Whitepaper { get; set; }

        [JsonProperty("blockchain_site")]
        public List<string> BlockchainSite { get; set; }

        [JsonProperty("official_forum_url")]
        public List<string> OfficialForumUrl { get; set; }

        [JsonProperty("chat_url")]
        public List<string> ChatUrl { get; set; }

        [JsonProperty("announcement_url")]
        public List<string> AnnouncementUrl { get; set; }

        [JsonProperty("twitter_screen_name")]
        public string TwitterScreenName { get; set; }

        [JsonProperty("facebook_username")]
        public string FacebookUsername { get; set; }

        [JsonProperty("bitcointalk_thread_identifier")]
        public string BitcointalkThreadIdentifier { get; set; }

        [JsonProperty("telegram_channel_identifier")]
        public string TelegramChannelIdentifier { get; set; }

        [JsonProperty("subreddit_url")]
        public string SubredditUrl { get; set; }

        [JsonProperty("repos_url")]
        public Dictionary<string, List<string>> ReposUrl { get; set; }
    }

    public class Image
    {
        [JsonProperty("thumb")]
        public string Thumb { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }
    }

    public class MarketData
    {
        [JsonProperty("current_price")]
        public Dictionary<string, double> CurrentPrice { get; set; }

        [JsonProperty("total_value_locked")]
        public object TotalValueLocked { get; set; }

        [JsonProperty("mcap_to_tvl_ratio")]
        public object McapToTvlRatio { get; set; }

        [JsonProperty("fdv_to_tvl_ratio")]
        public object FdvToTvlRatio { get; set; }

        [JsonProperty("roi")]
        public object Roi { get; set; }

        [JsonProperty("ath")]
        public Dictionary<string, double> Ath { get; set; }

        [JsonProperty("ath_change_percentage")]
        public Dictionary<string, double> AthChangePercentage { get; set; }

        [JsonProperty("ath_date")]
        public Dictionary<string, DateTime> AthDate { get; set; }

        [JsonProperty("atl")]
        public Dictionary<string, double> Atl { get; set; }

        [JsonProperty("atl_change_percentage")]
        public Dictionary<string, double> AtlChangePercentage { get; set; }

        [JsonProperty("atl_date")]
        public Dictionary<string, DateTime> AtlDate { get; set; }

        [JsonProperty("market_cap")]
        public Dictionary<string, double> MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("fully_diluted_valuation")]
        public Dictionary<string, double> FullyDilutedValuation { get; set; }

        [JsonProperty("total_volume")]
        public Dictionary<string, double> TotalVolume { get; set; }

        [JsonProperty("high_24h")]
        public Dictionary<string, double> High24H { get; set; }

        [JsonProperty("low_24h")]
        public Dictionary<string, double> Low24H { get; set; }

        [JsonProperty("price_change_24h")]
        public double? PriceChange24H { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public double? PriceChangePercentage24H { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public double? PriceChangePercentage7D { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public double? PriceChangePercentage14D { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public double? PriceChangePercentage30D { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public double? PriceChangePercentage60D { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public double? PriceChangePercentage200D { get; set; }

        [JsonProperty("price_change_percentage_1y")]
        public double? PriceChangePercentage1Y { get; set; }

        [JsonProperty("market_cap_change_24h")]
        public double? MarketCapChange24H { get; set; }

        [JsonProperty("market_cap_change_percentage_24h")]
        public double? MarketCapChangePercentage24H { get; set; }

        [JsonProperty("price_change_24h_in_currency")]
        public Dictionary<string, double> PriceChange24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public Dictionary<string, double> PriceChangePercentage24HInCurrency { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage7DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_14d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage14DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_30d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage30DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_60d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage60DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_200d_in_currency")]
        public Dictionary<string, double> PriceChangePercentage200DInCurrency { get; set; }

        [JsonProperty("price_change_percentage_1y_in_currency")]
        public Dictionary<string, double> PriceChangePercentage1YInCurrency { get; set; }

        [JsonProperty("market_cap_change_24h_in_currency")]
        public Dictionary<string, double> MarketCapChange24HInCurrency { get; set; }

        [JsonProperty("market_cap_change_percentage_24h_in_currency")]
        public Dictionary<string, double> MarketCapChangePercentage24HInCurrency { get; set; }

        [JsonProperty("total_supply")]
        public double? TotalSupply { get; set; }

        [JsonProperty("max_supply")]
        public double? MaxSupply { get; set; }

        [JsonProperty("circulating_supply")]
        public double? CirculatingSupply { get; set; }

        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; set; }
    }


    public class CryptoDetailsDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("web_slug")]
        public string WebSlug { get; set; }

        [JsonProperty("asset_platform_id")]
        public object AssetPlatformId { get; set; }

        [JsonProperty("platforms")]
        public Dictionary<string, string> Platforms { get; set; }

        [JsonProperty("detail_platforms")]
        public Dictionary<string, PlatformDetail> DetailPlatforms { get; set; }

        [JsonProperty("block_time_in_minutes")]
        public int BlockTimeInMinutes { get; set; }

        [JsonProperty("hashing_algorithm")]
        public string HashingAlgorithm { get; set; }

        [JsonProperty("categories")]
        public List<string> Categories { get; set; }

        [JsonProperty("preview_listing")]
        public bool PreviewListing { get; set; }

        [JsonProperty("public_notice")]
        public object PublicNotice { get; set; }

        [JsonProperty("additional_notices")]
        public List<object> AdditionalNotices { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("country_origin")]
        public string CountryOrigin { get; set; }

        [JsonProperty("sentiment_votes_up_percentage")]
        public double SentimentVotesUpPercentage { get; set; }

        [JsonProperty("sentiment_votes_down_percentage")]
        public double SentimentVotesDownPercentage { get; set; }

        [JsonProperty("watchlist_portfolio_users")]
        public int WatchlistPortfolioUsers { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("market_data")]
        public MarketData MarketData { get; set; }

        [JsonProperty("status_updates")]
        public List<object> StatusUpdates { get; set; }

        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }
    }

}
