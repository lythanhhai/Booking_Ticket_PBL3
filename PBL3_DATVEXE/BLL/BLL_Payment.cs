﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_DATVEXE.DAL;
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE.BLL
{
    public class BLL_Payment
    {
        private static BLL_Payment _Instance = null;
        public static BLL_Payment Instance
        {
            get
            {
                if (_Instance == null) return new BLL_Payment();
                return _Instance;
            }
            private set { }
        }
        public bool CheckPayment(string id_login,string id_person)
        {
            
            foreach(Payment i in DAL_Payment.Instance.Getpayment())
            {
               
                if (i.id_person == id_person)
                {
                    
                    return i.permission;
                }
            }
            return false;
        }
        public void DeletePayment(string id_order,string id_person)
        {
            string sql1 = "delete from orderSeat where id_order='" + id_order + "'";
            string sql2 = "delete from [MVH_07].[dbo].[Order] where id_order='" + id_order + "'";
            string sql3 = "delete from info_person where id_person='" + id_person + "'";
            DB_H.Instance.Ex(sql1);
            DB_H.Instance.Ex(sql2);
            DB_H.Instance.Ex(sql3);
        }
    }
}
