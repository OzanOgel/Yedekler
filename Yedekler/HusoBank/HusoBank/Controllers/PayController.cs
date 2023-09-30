using HusoBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace HusoBank.Controllers
{

    public class MerchandAPIM
    {
        public string MerchandID { get; set; }

        public string Password { get; set; }

        public string CardNumber { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string CCV { get; set; }

        public decimal Price { get; set; }



    }
    public class PayController : ApiController
    {
        HusoBank_DBEntities db = new HusoBank_DBEntities();

        public string PostPay(MerchandAPIM model)
        {
            int count = db.PosCustomers.Count(x => x.MerchantID == model.MerchandID && x.Password == model.Password);
            if (count > 0)
            {
                PosCustomers pc = db.PosCustomers.FirstOrDefault(x => x.MerchantID == model.MerchandID && x.Password == model.Password);
                if (pc.ExpDate > DateTime.Now)
                {
                    int CardCount = db.Customers.Count(x => x.CardNumber == model.CardNumber);
                    if (CardCount > 0)
                    {
                        Customers c = db.Customers.FirstOrDefault(x => x.CardNumber == model.CardNumber);
                        DateTime expDate =Convert.ToDateTime("30/" + c.ExpMonth + "/" + c.ExpYear);
                        if (expDate > DateTime.Now)
                        {
                            if(c.CCV == model.CCV)
                            {
                                if(c.Balance > model.Price)
                                {
                                    Customers update = db.Customers.Find(c.ID);
                                    update.Balance -= model.Price;
                                    PosCustomers updatepos = db.PosCustomers.Find(pc.ID);
                                    updatepos.Balance += model.Price;
                                    try
                                    {
                                        db.SaveChanges();
                                        return "210";
                                    }
                                    catch
                                    {
                                        return "300";
                                    }
                                }
                                else
                                {
                                    return "410";
                                }
                            }
                            else
                            {
                                return "505";
                            }
                        }
                        else
                        {
                            return "600";
                        }
                    }
                    else
                    {
                        return "700";
                    }
                }
                else
                {
                    return "800";
                }
            }
            else
            {
                return "900";
            }
        }

    }
}
