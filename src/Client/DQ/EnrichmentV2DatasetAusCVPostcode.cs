namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data to be returned, based on the Australian Postcode dataset.
    /// </summary>
    [DataContract]
    public class EnrichmentV2DatasetAusCVPostcode
    {
        /// <summary>
        /// The postal code of the address.
        /// </summary>
        /// <value>The postal code of the address.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// Estimate of the number of people aged 18 and over in a household.
        /// </summary>
        /// <value>Estimate of the number of people aged 18 and over in a household.</value>
        [DataMember(Name="adults_at_address_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "adults_at_address_code")]
        public string AdultsAtAddressCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="adults_at_address_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "adults_at_address_description")]
        public string AdultsAtAddressDescription { get; set; }

        /// <summary>
        /// A rating indicating the household level of wealth based on household             demographics, assets and investments.
        /// </summary>
        /// <value>A rating indicating the household level of wealth based on household             demographics, assets and investments.</value>
        [DataMember(Name="affluence_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "affluence_code")]
        public string AffluenceCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="affluence_code_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "affluence_code_description")]
        public string AffluenceCodeDescription { get; set; }

        /// <summary>
        /// A prediction of the presence of children aged 0-10 in a household.             Code represents one of 10 likelihood bands.
        /// </summary>
        /// <value>A prediction of the presence of children aged 0-10 in a household.             Code represents one of 10 likelihood bands.</value>
        [DataMember(Name="children_at_address_code_0_10_years", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "children_at_address_code_0_10_years")]
        public string ChildrenAtAddressCode010Years { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="children_at_address_description_0_10_years", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "children_at_address_description_0_10_years")]
        public string ChildrenAtAddressDescription010Years { get; set; }

        /// <summary>
        /// A prediction of the presence of children aged 11-18 in a household.
        /// </summary>
        /// <value>A prediction of the presence of children aged 11-18 in a household.</value>
        [DataMember(Name="children_at_address_code_11_18_years", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "children_at_address_code_11_18_years")]
        public string ChildrenAtAddressCode1118Years { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="children_at_address_description_11_18_years", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "children_at_address_description_11_18_years")]
        public string ChildrenAtAddressDescription1118Years { get; set; }

        /// <summary>
        /// An indicator of demand for credit at the sub meshblock level.             For privacy reasons, credit data is aggregated to a geographical region,             rather than a single address.
        /// </summary>
        /// <value>An indicator of demand for credit at the sub meshblock level.             For privacy reasons, credit data is aggregated to a geographical region,             rather than a single address.</value>
        [DataMember(Name="credit_demand_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "credit_demand_code")]
        public string CreditDemandCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="credit_demand_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "credit_demand_description")]
        public string CreditDemandDescription { get; set; }

        /// <summary>
        /// A prediction of the age for the person likely to be head of household.             Code represents one of 15 age bands.
        /// </summary>
        /// <value>A prediction of the age for the person likely to be head of household.             Code represents one of 15 age bands.</value>
        [DataMember(Name="head_of_household_age_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "head_of_household_age_code")]
        public string HeadOfHouseholdAgeCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="head_of_household_age_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "head_of_household_age_description")]
        public string HeadOfHouseholdAgeDescription { get; set; }

        /// <summary>
        /// Prediction of annual income of the household. Code represents one of             7 income bands.
        /// </summary>
        /// <value>Prediction of annual income of the household. Code represents one of             7 income bands.</value>
        [DataMember(Name="household_income_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_income_code")]
        public string HouseholdIncomeCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="household_income_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_income_description")]
        public string HouseholdIncomeDescription { get; set; }

        /// <summary>
        /// An estimate of the length of time a person or family has lived at an address.             Code represents one of 15 bands.
        /// </summary>
        /// <value>An estimate of the length of time a person or family has lived at an address.             Code represents one of 15 bands.</value>
        [DataMember(Name="length_of_residence_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "length_of_residence_code")]
        public string LengthOfResidenceCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="length_of_residence_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "length_of_residence_description")]
        public string LengthOfResidenceDescription { get; set; }

        /// <summary>
        /// An indication of the stage of life of the household occupants.             Represents one of 10 bands.
        /// </summary>
        /// <value>An indication of the stage of life of the household occupants.             Represents one of 10 bands.</value>
        [DataMember(Name="lifestage_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lifestage_code")]
        public string LifestageCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="lifestage_code_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lifestage_code_description")]
        public string LifestageCodeDescription { get; set; }

        /// <summary>
        /// 2018 Mosaic classification group. One of 13.  e.g. K.
        /// </summary>
        /// <value>2018 Mosaic classification group. One of 13.  e.g. K.</value>
        [DataMember(Name="mosaic_group_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group_2018")]
        public string MosaicGroup2018 { get; set; }

        /// <summary>
        /// 2018 mosaic classification group and type. One of 13 groups and 49 types. e.g. K39.
        /// </summary>
        /// <value>2018 mosaic classification group and type. One of 13 groups and 49 types. e.g. K39.</value>
        [DataMember(Name="mosaic_type_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type_2018")]
        public string MosaicType2018 { get; set; }

        /// <summary>
        /// Indication of the type of household in which the people at an address are living in.             Code represents one of 6 bands.
        /// </summary>
        /// <value>Indication of the type of household in which the people at an address are living in.             Code represents one of 6 bands.</value>
        [DataMember(Name="household_composition_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_composition_code")]
        public string HouseholdCompositionCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="household_composition_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_composition_description")]
        public string HouseholdCompositionDescription { get; set; }

        /// <summary>
        /// Indicator of risk at the sub meshblock level.             For privacy reasons, the bureau data is aggregated to a geographical region,             rather than a single address. Code represents one of 12 bands.
        /// </summary>
        /// <value>Indicator of risk at the sub meshblock level.             For privacy reasons, the bureau data is aggregated to a geographical region,             rather than a single address. Code represents one of 12 bands.</value>
        [DataMember(Name="risk_insight_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "risk_insight_code")]
        public string RiskInsightCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="risk_insight_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "risk_insight_description")]
        public string RiskInsightDescription { get; set; }

        /// <summary>
        /// 2015 Mosaic classification group. One of 13. e.g. K             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>2015 Mosaic classification group. One of 13. e.g. K             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_group", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group")]
        public string MosaicGroup { get; set; }

        /// <summary>
        /// 2015 Mosaic classification group and type.             One of 13 groups and 49 types. e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>2015 Mosaic classification group and type.             One of 13 groups and 49 types. e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type")]
        public string MosaicType { get; set; }

        /// <summary>
        /// 2015 Mosaic classification group. One of 13. e.g. K             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>2015 Mosaic classification group. One of 13. e.g. K             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_group_2015", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group_2015")]
        public string MosaicGroup2015 { get; set; }

        /// <summary>
        /// 2015 Mosaic classification group and type.             One of 13 groups and 49 types. e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>2015 Mosaic classification group and type.             One of 13 groups and 49 types. e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_type_2015", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type_2015")]
        public string MosaicType2015 { get; set; }
    }
}
