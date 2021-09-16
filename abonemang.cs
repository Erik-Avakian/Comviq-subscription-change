using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProv2_ABONEMANG
{
    class subscriptionPlan
    {


        public string name;

        public int internetData;

        public int monthlyCost;

        public int yearlyCost;



        public subscriptionPlan(string name, int internetData, int monthlyCost, int yearlyCost)
        {
            this.name = name;
            this.internetData = internetData;
            this.monthlyCost = monthlyCost;
            this.yearlyCost = yearlyCost;
        }



        public string GetSubscriptionPlanInfo()
        {
            return string.Format("Name: {0} \nInternetData: {1} \nMonthlyCost: {2} \nYearlyCost: {3}", name, internetData + " GB", "$" + monthlyCost, "$" + yearlyCost);

        }
    }
}
