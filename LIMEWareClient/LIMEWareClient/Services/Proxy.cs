using System;
using System.Text;

namespace FlexibleRewardingTestClient
{
    public class Proxy
    {
        MobileWebSvc service;
        public Proxy(string url)
        {
            service = new MobileWebSvc(url);
        }
        public string getPrimaryBalance(long msisdn)
        {
            try
            {
                int returnCode;
                bool returnCodeSpecified;
                string returnDescription;
                string subscriberId;
                string primaryOfferId;
                string ratingState;
                string primaryBalance;
                string balanceExpiry;

                service.getPrimaryBalance(msisdn, out returnCode, out returnCodeSpecified, out returnDescription, out subscriberId, out primaryOfferId, out ratingState, out primaryBalance, out balanceExpiry);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("returnCode=" + returnCode.ToString());
                sb.AppendLine("returnDescription=" + returnDescription);
                sb.AppendLine("subscriberId=" + subscriberId);
                sb.AppendLine("primaryOfferId=" + primaryOfferId);
                sb.AppendLine("ratingState=" + ratingState);
                sb.AppendLine("primaryBalance=" + primaryBalance);
                sb.AppendLine("balanceExpiry=" + balanceExpiry);

                return sb.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string externalBalanceUpdate(Parameters par)
        {
            try
            {
                externalBalanceUpdateChangeList changeList = new externalBalanceUpdateChangeList { changeBalance = new externalBalanceUpdateChangeListChangeBalance[] { new externalBalanceUpdateChangeListChangeBalance { balanceChangeValue = par.balanceChangeValue, balanceLabel = par.balanceLabel, eobTimeOverride = par.eobTimeOverride, expiryChange = par.expiryChange, extendFromEOB = par.extendFromEOB } } };
                int returnCode;
                bool returnCodeSpecified;
                string returnDescription;
                string requiredRecharge;
                externalBalanceUpdateResponseActiveDataList activeDataList;
                externalBalanceUpdateResponseActiveBalanceList activeBalanceList;

                service.externalBalanceUpdate(par.msisdn, par.promoId, changeList, out returnCode, out returnCodeSpecified, out returnDescription, out requiredRecharge, out activeDataList, out activeBalanceList);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("returnCode=" + returnCode.ToString());
                sb.AppendLine("returnDescription=" + returnDescription);
                sb.AppendLine("requiredRecharge=" + requiredRecharge);

                sb.AppendLine("dataBalance start");
                foreach (var databalance in activeDataList.dataBalance)
                {
                    sb.AppendLine("dataExpiry=" + databalance.dataExpiry);
                    sb.AppendLine("dataValue=" + databalance.dataValue.ToString());
                    sb.AppendLine("dataValueSpecified=" + databalance.dataValueSpecified.ToString());
                    sb.AppendLine("sapcRetCode=" + databalance.sapcRetCode.ToString());
                    sb.AppendLine("sapcRetCodeSpecified=" + databalance.sapcRetCodeSpecified.ToString());
                }
                sb.AppendLine("dataBalance end");

                sb.AppendLine("balance start");
                foreach (var balance in activeBalanceList.balance)
                {
                    sb.AppendLine("balCategory=" + balance.balCategory);
                    sb.AppendLine("balDisp=" + balance.balDisp);
                    sb.AppendLine("balExpiry=" + balance.balExpiry);
                    sb.AppendLine("balLongName=" + balance.balLongName);
                    sb.AppendLine("balName=" + balance.balName);
                    sb.AppendLine("balType=" + balance.balType);
                    sb.AppendLine("balValue=" + balance.balValue);
                }
                sb.AppendLine("balance end");

                return sb.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public void Dummy()
        {

        }
    }

    public class Parameters
    {
        public long msisdn { get; set; }
        public string promoId { get; set; }
        public string balanceChangeValue { get; set; }
        public string balanceLabel { get; set; }
        public string eobTimeOverride { get; set; }
        public string expiryChange { get; set; }
        public string extendFromEOB { get; set; }
    }

}
/**/
