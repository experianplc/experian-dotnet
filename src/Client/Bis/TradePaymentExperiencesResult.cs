namespace Experian.Api.Client.Bis
{
    using System;
    using System.Collections.Generic;

    public sealed class TradePaymentExperiencesResult
    {
        public List<TradeNewAndContinuousResult> TradeNewAndContinuous { get; set; }

        public List<TradeAdditionalResult> TradeAdditional { get; set; }
    }
}
