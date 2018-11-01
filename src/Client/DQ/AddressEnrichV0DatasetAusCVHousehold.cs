namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Enrichment data to be returned, based on the Australian Household dataset.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0DatasetAusCVHousehold
    {
        /// <summary>
        /// A unique Experian household identifier.
        /// </summary>
        /// <value>A unique Experian household identifier.</value>
        [DataMember(Name="hin", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "hin")]
        public string Hin { get; set; }

        /// <summary>
        /// The full address. An additional mail_suppression attribute             will be returned if the address is suppressed and should not be contacted.
        /// </summary>
        /// <value>The full address. An additional mail_suppression attribute             will be returned if the address is suppressed and should not be contacted.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// The suburb of the address.
        /// </summary>
        /// <value>The suburb of the address.</value>
        [DataMember(Name="suburb", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "suburb")]
        public string Suburb { get; set; }

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        /// <value>The postal code of the address.</value>
        [DataMember(Name="postcode", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "postcode")]
        public string Postcode { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Indicates whether the address is residential.
        /// </summary>
        /// <value>Indicates whether the address is residential.</value>
        [DataMember(Name="residential_flag", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "residential_flag")]
        public string ResidentialFlag { get; set; }

        /// <summary>
        /// The persistent identifier of the address.             This is a unique 14-character alphanumeric identifier of the address             record; for example, GANSW716798454”. An additional mail_suppression             attribute will be returned if the address is suppressed and should             not be contacted.
        /// </summary>
        /// <value>The persistent identifier of the address.             This is a unique 14-character alphanumeric identifier of the address             record; for example, GANSW716798454”. An additional mail_suppression             attribute will be returned if the address is suppressed and should             not be contacted.</value>
        [DataMember(Name="gnaf_pid", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gnaf_pid")]
        public string GnafPid { get; set; }

        /// <summary>
        /// The address-level latitude in degrees.
        /// </summary>
        /// <value>The address-level latitude in degrees.</value>
        [DataMember(Name="gnaf_latitude", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gnaf_latitude")]
        public double? GnafLatitude { get; set; }

        /// <summary>
        /// The address-level longitude in degrees.
        /// </summary>
        /// <value>The address-level longitude in degrees.</value>
        [DataMember(Name="gnaf_longitude", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "gnaf_longitude")]
        public double? GnafLongitude { get; set; }

        /// <summary>
        /// The Mesh Block ID. This element consists of 15 alphanumeric             characters: a 4 character descriptor, followed by the 11 digit Mesh Block Code.
        /// </summary>
        /// <value>The Mesh Block ID. This element consists of 15 alphanumeric             characters: a 4 character descriptor, followed by the 11 digit Mesh Block Code.</value>
        [DataMember(Name="meshblock", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "meshblock")]
        public string Meshblock { get; set; }

        /// <summary>
        /// The 7 digit SA1 code.
        /// </summary>
        /// <value>The 7 digit SA1 code.</value>
        [DataMember(Name="sa1", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "sa1")]
        public string Sa1 { get; set; }

        /// <summary>
        /// The Local Government Area persistent identifier.
        /// </summary>
        /// <value>The Local Government Area persistent identifier.</value>
        [DataMember(Name="local_government_area_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "local_government_area_code")]
        public string LocalGovernmentAreaCode { get; set; }

        /// <summary>
        /// The Local Government Area name.
        /// </summary>
        /// <value>The Local Government Area name.</value>
        [DataMember(Name="local_government_area_name", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "local_government_area_name")]
        public string LocalGovernmentAreaName { get; set; }

        /// <summary>
        /// The 2018 Mosaic group, e.g. K.
        /// </summary>
        /// <value>The 2018 Mosaic group, e.g. K.</value>
        [DataMember(Name="mosaic_group_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group_2018")]
        public string MosaicGroup2018 { get; set; }

        /// <summary>
        /// The 2018 Mosaic group and type, e.g. K39.
        /// </summary>
        /// <value>The 2018 Mosaic group and type, e.g. K39.</value>
        [DataMember(Name="mosaic_type_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type_2018")]
        public string MosaicType2018 { get; set; }

        /// <summary>
        /// The 2018 Mosaic group, type and segment e.g. K39_4.
        /// </summary>
        /// <value>The 2018 Mosaic group, type and segment e.g. K39_4.</value>
        [DataMember(Name="mosaic_segment_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_segment_2018")]
        public string MosaicSegment2018 { get; set; }

        /// <summary>
        /// A rating indicating the household level of wealth based on             household demographics, assets and investments.
        /// </summary>
        /// <value>A rating indicating the household level of wealth based on             household demographics, assets and investments.</value>
        [DataMember(Name="affluence_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "affluence_code")]
        public string AffluenceCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="affluence_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "affluence_description")]
        public string AffluenceDescription { get; set; }

        /// <summary>
        /// Estimate of the number of people aged 18 and over in a household.
        /// </summary>
        /// <value>Estimate of the number of people aged 18 and over in a household.</value>
        [DataMember(Name="adults_at_address_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "adults_at_address_code")]
        public string AdultsAtAddressCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="adults_at_address_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "adults_at_address_description")]
        public string AdultsAtAddressDescription { get; set; }

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
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
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
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="credit_demand_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "credit_demand_description")]
        public string CreditDemandDescription { get; set; }

        /// <summary>
        /// Prediction of annual income of the household. Code represents one of             7 income bands.
        /// </summary>
        /// <value>Prediction of annual income of the household. Code represents one of             7 income bands.</value>
        [DataMember(Name="household_income_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_income_code")]
        public string HouseholdIncomeCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="household_income_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_income_description")]
        public string HouseholdIncomeDescription { get; set; }

        /// <summary>
        /// Indication of the type of household in which the people at an address             are living in. Code represents one of 6 bands.
        /// </summary>
        /// <value>Indication of the type of household in which the people at an address             are living in. Code represents one of 6 bands.</value>
        [DataMember(Name="household_composition_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_composition_code")]
        public string HouseholdCompositionCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="household_composition_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "household_composition_description")]
        public string HouseholdCompositionDescription { get; set; }

        /// <summary>
        /// A prediction of the age for the person likely to be head of household.             Code represents one of 15 age bands.
        /// </summary>
        /// <value>A prediction of the age for the person likely to be head of household.             Code represents one of 15 age bands.</value>
        [DataMember(Name="head_of_household_age_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "head_of_household_age_code")]
        public string HeadOfHouseholdAgeCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="head_of_household_age_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "head_of_household_age_description")]
        public string HeadOfHouseholdAgeDescription { get; set; }

        /// <summary>
        /// An indication of the stage of life of the household occupants.             Represents one of 10 bands.
        /// </summary>
        /// <value>An indication of the stage of life of the household occupants.             Represents one of 10 bands.</value>
        [DataMember(Name="lifestage_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lifestage_code")]
        public string LifestageCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="lifestage_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lifestage_description")]
        public string LifestageDescription { get; set; }

        /// <summary>
        /// An estimate of the length of time a person or family has lived at an address.             Code represents one of 15 bands.
        /// </summary>
        /// <value>An estimate of the length of time a person or family has lived at an address.             Code represents one of 15 bands.</value>
        [DataMember(Name="length_of_residence_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "length_of_residence_code")]
        public string LengthOfResidenceCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="length_of_residence_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "length_of_residence_description")]
        public string LengthOfResidenceDescription { get; set; }

        /// <summary>
        /// Mosaic factor score for Family Composition.
        /// </summary>
        /// <value>Mosaic factor score for Family Composition.</value>
        [DataMember(Name="mosaic_factor1_score_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor1_score_2018")]
        public string MosaicFactor1Score2018 { get; set; }

        /// <summary>
        /// Mosaic factor score for Prosperity.
        /// </summary>
        /// <value>Mosaic factor score for Prosperity.</value>
        [DataMember(Name="mosaic_factor2_score_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor2_score_2018")]
        public string MosaicFactor2Score2018 { get; set; }

        /// <summary>
        /// Mosaic factor score for Dependants.
        /// </summary>
        /// <value>Mosaic factor score for Dependants.</value>
        [DataMember(Name="mosaic_factor3_score_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor3_score_2018")]
        public string MosaicFactor3Score2018 { get; set; }

        /// <summary>
        /// Mosaic factor score for Cultural Diversity.
        /// </summary>
        /// <value>Mosaic factor score for Cultural Diversity.</value>
        [DataMember(Name="mosaic_factor4_score_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor4_score_2018")]
        public string MosaicFactor4Score2018 { get; set; }

        /// <summary>
        /// Mosaic factor score for Housing Ownership.
        /// </summary>
        /// <value>Mosaic factor score for Housing Ownership.</value>
        [DataMember(Name="mosaic_factor5_score_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor5_score_2018")]
        public string MosaicFactor5Score2018 { get; set; }

        /// <summary>
        /// Mosaic factor percentile for Family Composition.
        /// </summary>
        /// <value>Mosaic factor percentile for Family Composition.</value>
        [DataMember(Name="mosaic_factor1_percentile_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor1_percentile_2018")]
        public string MosaicFactor1Percentile2018 { get; set; }

        /// <summary>
        /// Mosaic factor percentile for Prosperity.
        /// </summary>
        /// <value>Mosaic factor percentile for Prosperity.</value>
        [DataMember(Name="mosaic_factor2_percentile_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor2_percentile_2018")]
        public string MosaicFactor2Percentile2018 { get; set; }

        /// <summary>
        /// Mosaic factor percentile for Dependants.
        /// </summary>
        /// <value>Mosaic factor percentile for Dependants.</value>
        [DataMember(Name="mosaic_factor3_percentile_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor3_percentile_2018")]
        public string MosaicFactor3Percentile2018 { get; set; }

        /// <summary>
        /// Mosaic factor percentile for Cultural Diversity.
        /// </summary>
        /// <value>Mosaic factor percentile for Cultural Diversity.</value>
        [DataMember(Name="mosaic_factor4_percentile_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor4_percentile_2018")]
        public string MosaicFactor4Percentile2018 { get; set; }

        /// <summary>
        /// Mosaic factor percentile for Housing Ownership.
        /// </summary>
        /// <value>Mosaic factor percentile for Housing Ownership.</value>
        [DataMember(Name="mosaic_factor5_percentile_2018", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_factor5_percentile_2018")]
        public string MosaicFactor5Percentile2018 { get; set; }

        /// <summary>
        /// Indicator of risk at the sub meshblock level.             For privacy reasons, the bureau data is aggregated to a geographical region,             rather than a single address. Code represents one of 12 bands.
        /// </summary>
        /// <value>Indicator of risk at the sub meshblock level.             For privacy reasons, the bureau data is aggregated to a geographical region,             rather than a single address. Code represents one of 12 bands.</value>
        [DataMember(Name="risk_insight_code", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "risk_insight_code")]
        public string RiskInsightCode { get; set; }

        /// <summary>
        /// Description of the code returned for the above attribute.
        /// </summary>
        /// <value>Description of the code returned for the above attribute.</value>
        [DataMember(Name="risk_insight_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "risk_insight_description")]
        public string RiskInsightDescription { get; set; }

        /// <summary>
        /// Channel Preferences classifies every Australian household             into one of eight unique segments based on their most preferred form of media.             This is provided as a code ranging from 1 to 8.
        /// </summary>
        /// <value>Channel Preferences classifies every Australian household             into one of eight unique segments based on their most preferred form of media.             This is provided as a code ranging from 1 to 8.</value>
        [DataMember(Name="channel_preference", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "channel_preference")]
        public string ChannelPreference { get; set; }

        /// <summary>
        /// Channel Preferences classifies every Australian household             into one of eight unique segments based on their most preferred form of media.             This is provided as a description.
        /// </summary>
        /// <value>Channel Preferences classifies every Australian household             into one of eight unique segments based on their most preferred form of media.             This is provided as a description.</value>
        [DataMember(Name="channel_preference_description", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "channel_preference_description")]
        public string ChannelPreferenceDescription { get; set; }

        /// <summary>
        /// The 2015 Mosaic group, e.g. K.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>The 2015 Mosaic group, e.g. K.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_group", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group")]
        public string MosaicGroup { get; set; }

        /// <summary>
        /// The 2015 Mosaic group and type, e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>The 2015 Mosaic group and type, e.g. K39.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_type", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type")]
        public string MosaicType { get; set; }

        /// <summary>
        /// The 2015 Mosaic group, type and segment e.g. K39_4.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)
        /// </summary>
        /// <value>The 2015 Mosaic group, type and segment e.g. K39_4.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.)</value>
        [DataMember(Name="mosaic_segment", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_segment")]
        public string MosaicSegment { get; set; }

        /// <summary>
        /// The 2015 Mosaic group, e.g. K. (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.).
        /// </summary>
        /// <value>The 2015 Mosaic group, e.g. K. (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.).</value>
        [DataMember(Name="mosaic_group_2015", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_group_2015")]
        public string MosaicGroup2015 { get; set; }

        /// <summary>
        /// The 2015 Mosaic group and type, e.g. K39.             (Remains for backward compatibility for existing integrated customers only.             Please use latest available Mosaic attributes instead.).
        /// </summary>
        /// <value>The 2015 Mosaic group and type, e.g. K39.             (Remains for backward compatibility for existing integrated customers only.             Please use latest available Mosaic attributes instead.).</value>
        [DataMember(Name="mosaic_type_2015", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_type_2015")]
        public string MosaicType2015 { get; set; }

        /// <summary>
        /// The 2015 Mosaic group, type and segment e.g. K39_4.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.).
        /// </summary>
        /// <value>The 2015 Mosaic group, type and segment e.g. K39_4.             (Remains for backward compatibility purposes only.             Please consider using the latest available Mosaic attributes instead.).</value>
        [DataMember(Name="mosaic_segment_2015", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mosaic_segment_2015")]
        public string MosaicSegment2015 { get; set; }

        /// <summary>
        /// The description of the mail suppression status.
        /// </summary>
        /// <value>The description of the mail suppression status.</value>
        [DataMember(Name="mail_suppression", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "mail_suppression")]
        public string MailSuppression { get; set; }
    }
}
