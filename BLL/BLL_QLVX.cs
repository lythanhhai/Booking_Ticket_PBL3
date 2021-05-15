using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3_DATVEXE.DAL;
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE.BLL
{
    class BLL_QLVX
    {
        private static BLL_QLVX _Instance;

        public static BLL_QLVX Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QLVX();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public List<DTO_QLVX> getallQLVX()
        {
            return DAL_QLVX.Instance.getallQLVX();

        }
    }
}
