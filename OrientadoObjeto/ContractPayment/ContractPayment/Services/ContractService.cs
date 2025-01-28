using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContractPayment.Entities;

namespace ContractPayment.Services
{
    internal class ContractService
    {
        IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double monthlyValue = contract.TotalValue / months;

            double totalValue = 0.0;
            for (int i = 0; i < months; i++)
            {
                totalValue = monthlyValue;

                DateTime contractMonth = contract.Date.AddMonths(i+1);

                totalValue += _onlinePaymentService.PaymentFee(monthlyValue);
                totalValue += _onlinePaymentService.Interest(totalValue, i+1);

                contract.AddInstallment(new Installment(contractMonth, totalValue));
            }
        }
    }
}
